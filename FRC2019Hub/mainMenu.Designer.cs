﻿namespace FRC2019Hub
{
    partial class mainMenu
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
            this.simPicBtn = new System.Windows.Forms.PictureBox();
            this.simBox = new System.Windows.Forms.PictureBox();
            this.mafiaPicBtn = new System.Windows.Forms.PictureBox();
            this.invaderPicBtn = new System.Windows.Forms.PictureBox();
            this.mafiaBox = new System.Windows.Forms.PictureBox();
            this.invaderBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.simPicBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mafiaPicBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invaderPicBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mafiaBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invaderBox)).BeginInit();
            this.SuspendLayout();
            // 
            // simPicBtn
            // 
            this.simPicBtn.Image = global::FRC2019Hub.Properties.Resources.simBtn;
            this.simPicBtn.Location = new System.Drawing.Point(548, 239);
            this.simPicBtn.Name = "simPicBtn";
            this.simPicBtn.Size = new System.Drawing.Size(160, 50);
            this.simPicBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.simPicBtn.TabIndex = 5;
            this.simPicBtn.TabStop = false;
            this.simPicBtn.Click += new System.EventHandler(this.SimPicBtn_Click);
            // 
            // simBox
            // 
            this.simBox.Image = global::FRC2019Hub.Properties.Resources.sim;
            this.simBox.Location = new System.Drawing.Point(-3, 189);
            this.simBox.Name = "simBox";
            this.simBox.Size = new System.Drawing.Size(800, 100);
            this.simBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.simBox.TabIndex = 4;
            this.simBox.TabStop = false;
            // 
            // mafiaPicBtn
            // 
            this.mafiaPicBtn.Image = global::FRC2019Hub.Properties.Resources.mafiaBtn;
            this.mafiaPicBtn.Location = new System.Drawing.Point(589, 143);
            this.mafiaPicBtn.Name = "mafiaPicBtn";
            this.mafiaPicBtn.Size = new System.Drawing.Size(160, 50);
            this.mafiaPicBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mafiaPicBtn.TabIndex = 3;
            this.mafiaPicBtn.TabStop = false;
            this.mafiaPicBtn.Click += new System.EventHandler(this.MafiaPicBtn_Click);
            // 
            // invaderPicBtn
            // 
            this.invaderPicBtn.Image = global::FRC2019Hub.Properties.Resources.smithBtn;
            this.invaderPicBtn.Location = new System.Drawing.Point(658, 4);
            this.invaderPicBtn.Name = "invaderPicBtn";
            this.invaderPicBtn.Size = new System.Drawing.Size(124, 56);
            this.invaderPicBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.invaderPicBtn.TabIndex = 2;
            this.invaderPicBtn.TabStop = false;
            this.invaderPicBtn.Click += new System.EventHandler(this.InvaderPicBtn_Click);
            // 
            // mafiaBox
            // 
            this.mafiaBox.Image = global::FRC2019Hub.Properties.Resources.mafia;
            this.mafiaBox.Location = new System.Drawing.Point(-3, 93);
            this.mafiaBox.Name = "mafiaBox";
            this.mafiaBox.Size = new System.Drawing.Size(800, 100);
            this.mafiaBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.mafiaBox.TabIndex = 1;
            this.mafiaBox.TabStop = false;
            // 
            // invaderBox
            // 
            this.invaderBox.Image = global::FRC2019Hub.Properties.Resources.smith;
            this.invaderBox.Location = new System.Drawing.Point(-3, -1);
            this.invaderBox.Name = "invaderBox";
            this.invaderBox.Size = new System.Drawing.Size(800, 100);
            this.invaderBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.invaderBox.TabIndex = 0;
            this.invaderBox.TabStop = false;
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 289);
            this.Controls.Add(this.simPicBtn);
            this.Controls.Add(this.simBox);
            this.Controls.Add(this.mafiaPicBtn);
            this.Controls.Add(this.invaderPicBtn);
            this.Controls.Add(this.mafiaBox);
            this.Controls.Add(this.invaderBox);
            this.Name = "mainMenu";
            this.Text = "mainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.simPicBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mafiaPicBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invaderPicBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mafiaBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invaderBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox invaderBox;
        private System.Windows.Forms.PictureBox mafiaBox;
        private System.Windows.Forms.PictureBox invaderPicBtn;
        private System.Windows.Forms.PictureBox mafiaPicBtn;
        private System.Windows.Forms.PictureBox simPicBtn;
        private System.Windows.Forms.PictureBox simBox;
    }
}