﻿namespace VTCManager_1._0._0
{
    partial class ETS2_Pfad_Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ETS2_Pfad_Window));
            this.label1 = new System.Windows.Forms.Label();
            this.ets_pfad = new System.Windows.Forms.TextBox();
            this.btn_Suche_ETS = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ats_pfad = new System.Windows.Forms.TextBox();
            this.btn_Suche_ATS = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.folderBrowserDialog_ETS = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog_ATS = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(156, 18);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(474, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bitte gib die Installationspfade an !";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ets_pfad
            // 
            this.ets_pfad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ets_pfad.Location = new System.Drawing.Point(156, 97);
            this.ets_pfad.Name = "ets_pfad";
            this.ets_pfad.Size = new System.Drawing.Size(425, 26);
            this.ets_pfad.TabIndex = 2;
            this.ets_pfad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_Suche_ETS
            // 
            this.btn_Suche_ETS.Location = new System.Drawing.Point(587, 97);
            this.btn_Suche_ETS.Name = "btn_Suche_ETS";
            this.btn_Suche_ETS.Size = new System.Drawing.Size(40, 26);
            this.btn_Suche_ETS.TabIndex = 3;
            this.btn_Suche_ETS.Text = "...";
            this.btn_Suche_ETS.UseVisualStyleBackColor = true;
            this.btn_Suche_ETS.Click += new System.EventHandler(this.btn_Suche_ETS_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(26, 203);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(124, 68);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ats_pfad
            // 
            this.ats_pfad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ats_pfad.Location = new System.Drawing.Point(156, 203);
            this.ats_pfad.Name = "ats_pfad";
            this.ats_pfad.Size = new System.Drawing.Size(425, 26);
            this.ats_pfad.TabIndex = 5;
            // 
            // btn_Suche_ATS
            // 
            this.btn_Suche_ATS.Location = new System.Drawing.Point(587, 203);
            this.btn_Suche_ATS.Name = "btn_Suche_ATS";
            this.btn_Suche_ATS.Size = new System.Drawing.Size(43, 26);
            this.btn_Suche_ATS.TabIndex = 6;
            this.btn_Suche_ATS.Text = "...";
            this.btn_Suche_ATS.UseVisualStyleBackColor = true;
            this.btn_Suche_ATS.Click += new System.EventHandler(this.btn_Suche_ATS_Click);
            // 
            // button_ok
            // 
            this.button_ok.BackColor = System.Drawing.Color.ForestGreen;
            this.button_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ok.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_ok.Location = new System.Drawing.Point(469, 273);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(161, 32);
            this.button_ok.TabIndex = 7;
            this.button_ok.Text = "Fertig !";
            this.button_ok.UseVisualStyleBackColor = false;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // folderBrowserDialog_ETS
            // 
            this.folderBrowserDialog_ETS.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // folderBrowserDialog_ATS
            // 
            this.folderBrowserDialog_ATS.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(156, 126);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(3);
            this.label2.Size = new System.Drawing.Size(307, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "( Pfad bis Euro Truck Simulator 2 Installationsordner angeben!)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(156, 232);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3);
            this.label3.Size = new System.Drawing.Size(320, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "( Pfad bis American Truck Simulator Installationsordner angeben!)";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::VTCManager_1._0._0.Properties.Resources.favicon;
            this.pictureBox3.Location = new System.Drawing.Point(26, 18);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(124, 57);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // ETS2_Pfad_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::VTCManager_1._0._0.Properties.Resources.backi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(659, 327);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_ok);
            this.Controls.Add(this.btn_Suche_ATS);
            this.Controls.Add(this.ats_pfad);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btn_Suche_ETS);
            this.Controls.Add(this.ets_pfad);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "ETS2_Pfad_Window";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pfad angeben....";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ETS2_Pfad_Window_FormClosing);
            this.Load += new System.EventHandler(this.ETS2_Pfad_Window_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox ets_pfad;
        private System.Windows.Forms.Button btn_Suche_ETS;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox ats_pfad;
        private System.Windows.Forms.Button btn_Suche_ATS;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_ETS;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog_ATS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}