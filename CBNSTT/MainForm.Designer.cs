﻿namespace CBNSTT
{
    partial class MainForm
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
            this.PackerBtn = new System.Windows.Forms.Button();
            this.TextEditBtn = new System.Windows.Forms.Button();
            this.FontEditBtn = new System.Windows.Forms.Button();
            this.TextureBtn = new System.Windows.Forms.Button();
            this.sndBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PackerBtn
            // 
            this.PackerBtn.Location = new System.Drawing.Point(43, 31);
            this.PackerBtn.Name = "PackerBtn";
            this.PackerBtn.Size = new System.Drawing.Size(138, 23);
            this.PackerBtn.TabIndex = 0;
            this.PackerBtn.Text = "Packer tool";
            this.PackerBtn.UseVisualStyleBackColor = true;
            this.PackerBtn.Click += new System.EventHandler(this.PackerBtn_Click);
            // 
            // TextEditBtn
            // 
            this.TextEditBtn.Location = new System.Drawing.Point(235, 31);
            this.TextEditBtn.Name = "TextEditBtn";
            this.TextEditBtn.Size = new System.Drawing.Size(142, 23);
            this.TextEditBtn.TabIndex = 1;
            this.TextEditBtn.Text = "Text Editor";
            this.TextEditBtn.UseVisualStyleBackColor = true;
            this.TextEditBtn.Click += new System.EventHandler(this.TextEditBtn_Click);
            // 
            // FontEditBtn
            // 
            this.FontEditBtn.Location = new System.Drawing.Point(43, 92);
            this.FontEditBtn.Name = "FontEditBtn";
            this.FontEditBtn.Size = new System.Drawing.Size(142, 23);
            this.FontEditBtn.TabIndex = 2;
            this.FontEditBtn.Text = "Font Editor";
            this.FontEditBtn.UseVisualStyleBackColor = true;
            this.FontEditBtn.Click += new System.EventHandler(this.FontEditBtn_Click);
            // 
            // TextureBtn
            // 
            this.TextureBtn.Location = new System.Drawing.Point(235, 92);
            this.TextureBtn.Name = "TextureBtn";
            this.TextureBtn.Size = new System.Drawing.Size(142, 23);
            this.TextureBtn.TabIndex = 3;
            this.TextureBtn.Text = "Texture Tool";
            this.TextureBtn.UseVisualStyleBackColor = true;
            this.TextureBtn.Click += new System.EventHandler(this.TextureBtn_Click);
            // 
            // sndBtn
            // 
            this.sndBtn.Location = new System.Drawing.Point(141, 157);
            this.sndBtn.Name = "sndBtn";
            this.sndBtn.Size = new System.Drawing.Size(131, 23);
            this.sndBtn.TabIndex = 4;
            this.sndBtn.Text = "Sound Tool";
            this.sndBtn.UseVisualStyleBackColor = true;
            this.sndBtn.Click += new System.EventHandler(this.sndBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 209);
            this.Controls.Add(this.sndBtn);
            this.Controls.Add(this.TextureBtn);
            this.Controls.Add(this.FontEditBtn);
            this.Controls.Add(this.TextEditBtn);
            this.Controls.Add(this.PackerBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Crash Bandicoot Tool";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PackerBtn;
        private System.Windows.Forms.Button TextEditBtn;
        private System.Windows.Forms.Button FontEditBtn;
        private System.Windows.Forms.Button TextureBtn;
        private System.Windows.Forms.Button sndBtn;
    }
}
