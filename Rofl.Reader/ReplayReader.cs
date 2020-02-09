﻿using System;
using System.IO;
using System.Threading.Tasks;
using Rofl.Reader.Parsers;
using Rofl.Reader.Models;
using Rofl.Reader.Utilities;
using Rofl.Reader.Models.Internal.ROFL;
using System.Linq;
using Rofl.Logger;

namespace Rofl.Reader
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Globalization", "CA1303:Do not pass literals as localized parameters", Justification = "<Pending>")]
    public class ReplayReader
    {
        private readonly Scribe _log;

        private readonly string _myName;

        public ReplayReader(Scribe log)
        {
            _log = log;
            _myName = this.GetType().ToString();
        }

        public async Task<ReplayFile> ReadFile(string filePath)
        {
            // Make sure file exists
            if (String.IsNullOrEmpty(filePath))
            {
                throw new ArgumentNullException($"{_myName} - File reference is null");
            }

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"{_myName} - File path not found, does the file exist?");
            }

            // Reads the first 4 bytes and tries to find out the replay type
            ReplayType type = await ParserHelpers.GetReplayTypeAsync(filePath);
            
            // Match parsers to file types
            ReplayFile result;
            switch (type)
            {
                case ReplayType.ROFL:   // Official Replays
                    result = await ReadROFL(filePath);
                    break;
                //case ReplayType.LRF:    // LOLReplay
                //    file.Type = ReplayType.LRF;
                //    file.Data = await ReadLRF(file.Location);
                //    break;
                //case ReplayType.LPR:    // BaronReplays
                //    file.Type = ReplayType.LPR;
                //    file.Data = null;
                //    break;
                default:
                    throw new NotSupportedException($"{_myName} - File is not an accepted format: (rofl, lrf)");
            }

            // Make some educated guesses
            GameDetailsInferrer detailsInferrer = new GameDetailsInferrer();

            result.Players = result.BluePlayers.Union(result.RedPlayers).ToArray();

            try
            {
                result.MapId = detailsInferrer.InferMap(result.Players);
            }
            catch (ArgumentNullException ex)
            {
                _log.Warning(_myName, "Could not infer map type\n" + ex.ToString());
                result.MapId = MapCode.Unknown;
            }
            
            result.MapName = detailsInferrer.GetMapName(result.MapId);
            result.IsBlueVictorious = detailsInferrer.InferBlueVictory(result.BluePlayers, result.RedPlayers);

            foreach (var player in result.Players)
            {
                player.Id = $"{result.MatchId}_{player.PlayerID}";
            }

            return result;
        }

        public async Task<ReplayFile> ReadROFL(string filePath)
        {
            // Create a new parser
            ROFLParser roflParser = new ROFLParser();

            // Open file stream and parse
            ROFLHeader parseResult = null;
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
            {
                parseResult = (ROFLHeader) await roflParser.ReadReplayAsync(fileStream);
            }

            // Create replay file based on header
            return new ReplayFile
            {
                Type = ReplayType.ROFL,
                Name = Path.GetFileNameWithoutExtension(filePath),
                Location = filePath,
                MatchId = parseResult.PayloadFields.MatchId.ToString(),
                GameDuration = TimeSpan.FromMilliseconds(parseResult.MatchMetadata.GameDuration),
                GameVersion = parseResult.MatchMetadata.GameVersion,
                BluePlayers = parseResult.MatchMetadata.BluePlayers ?? new Player[0],
                RedPlayers = parseResult.MatchMetadata.RedPlayers ?? new Player[0],
                RawJsonString = parseResult.RawJsonString
            };
        }

        //public async Task<ReplayHeader> ReadLRF(string filePath)
        //{
        //    var lrfParser = new LrfParser();

        //    using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
        //    {
        //        return await lrfParser.ReadReplayAsync(fileStream);
        //    }
        //}

        //// Broken, do not use
        //public async Task<ReplayHeader> ReadLPR(string filePath)
        //{
        //    var lprParser = new LprParser();

        //    using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
        //    {
        //        return await lprParser.ReadReplayAsync(fileStream);
        //    }
        //}
    }
}
