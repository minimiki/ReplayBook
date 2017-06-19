﻿namespace ROFLPlayer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelValid = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.labelLoLPath = new System.Windows.Forms.Label();
            this.textBoxLoLPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPlay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.buttonClear);
            this.splitContainer1.Panel1.Controls.Add(this.buttonBrowse);
            this.splitContainer1.Panel1.Controls.Add(this.labelLoLPath);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxLoLPath);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AllowDrop = true;
            this.splitContainer1.Panel2.Controls.Add(this.buttonPlay);
            this.splitContainer1.Panel2.Controls.Add(this.labelValid);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.DragDrop += new System.Windows.Forms.DragEventHandler(this.splitsplitContainer1_Panel2_DragDrop);
            this.splitContainer1.Panel2.DragEnter += new System.Windows.Forms.DragEventHandler(this.splitsplitContainer1_Panel2_DragEnter);
            this.splitContainer1.Panel2.DragOver += new System.Windows.Forms.DragEventHandler(this.splitsplitContainer1_Panel2_DragOver);
            this.splitContainer1.Size = new System.Drawing.Size(284, 261);
            this.splitContainer1.SplitterDistance = 75;
            this.splitContainer1.TabIndex = 0;
            // 
            // labelValid
            // 
            this.labelValid.AutoSize = true;
            this.labelValid.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValid.ForeColor = System.Drawing.Color.Red;
            this.labelValid.Location = new System.Drawing.Point(120, 67);
            this.labelValid.Name = "labelValid";
            this.labelValid.Size = new System.Drawing.Size(41, 39);
            this.labelValid.TabIndex = 4;
            this.labelValid.Text = "X";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(116, 47);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(197, 47);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowse.TabIndex = 2;
            this.buttonBrowse.Text = "Browse...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // labelLoLPath
            // 
            this.labelLoLPath.AutoSize = true;
            this.labelLoLPath.Location = new System.Drawing.Point(9, 5);
            this.labelLoLPath.Name = "labelLoLPath";
            this.labelLoLPath.Size = new System.Drawing.Size(152, 13);
            this.labelLoLPath.TabIndex = 1;
            this.labelLoLPath.Text = "League of Legends (.exe) path";
            // 
            // textBoxLoLPath
            // 
            this.textBoxLoLPath.AllowDrop = true;
            this.textBoxLoLPath.Location = new System.Drawing.Point(12, 21);
            this.textBoxLoLPath.Name = "textBoxLoLPath";
            this.textBoxLoLPath.Size = new System.Drawing.Size(260, 20);
            this.textBoxLoLPath.TabIndex = 0;
            this.textBoxLoLPath.Text = "Browse for LoL game executable...";
            this.textBoxLoLPath.TextChanged += new System.EventHandler(this.textBoxLoLPath_TextChanged);
            this.textBoxLoLPath.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxLoLPath_DragDrop);
            this.textBoxLoLPath.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBoxLoLPath_DragEnter);
            this.textBoxLoLPath.DragOver += new System.Windows.Forms.DragEventHandler(this.textBoxLolPath_DragOver);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Drag Replays Here";
            // 
            // buttonPlay
            // 
            this.buttonPlay.Enabled = false;
            this.buttonPlay.Location = new System.Drawing.Point(106, 109);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(75, 23);
            this.buttonPlay.TabIndex = 5;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "ROFL Player";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelLoLPath;
        private System.Windows.Forms.TextBox textBoxLoLPath;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Label labelValid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPlay;
    }
}
