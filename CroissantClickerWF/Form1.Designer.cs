﻿using System;
using System.Drawing;
using System.Windows.Forms;
using CroissantClicker.Common;

namespace CroissantClickerWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.croissantsLabel = new System.Windows.Forms.Label();
            this.rateLabel = new System.Windows.Forms.Label();
            this.clicksLabel = new System.Windows.Forms.Label();
            this.basicBakerButton = new System.Windows.Forms.Button();
            this.basicBakerPowerIncrease = new System.Windows.Forms.Label();
            this.basicBakerCount = new System.Windows.Forms.Label();
            this.basicBakerCost = new System.Windows.Forms.Label();
            this.aboutButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.versionLabel = new System.Windows.Forms.Label();
            this.croissantImage = new System.Windows.Forms.PictureBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.croissantImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Croissants:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rate:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Clicks:";
            // 
            // croissantsLabel
            // 
            this.croissantsLabel.AutoSize = true;
            this.croissantsLabel.Location = new System.Drawing.Point(92, 11);
            this.croissantsLabel.Name = "croissantsLabel";
            this.croissantsLabel.Size = new System.Drawing.Size(13, 13);
            this.croissantsLabel.TabIndex = 5;
            this.croissantsLabel.Text = "0";
            // 
            // rateLabel
            // 
            this.rateLabel.AutoSize = true;
            this.rateLabel.Location = new System.Drawing.Point(58, 43);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(13, 13);
            this.rateLabel.TabIndex = 6;
            this.rateLabel.Text = "0";
            // 
            // clicksLabel
            // 
            this.clicksLabel.AutoSize = true;
            this.clicksLabel.Location = new System.Drawing.Point(65, 74);
            this.clicksLabel.Name = "clicksLabel";
            this.clicksLabel.Size = new System.Drawing.Size(13, 13);
            this.clicksLabel.TabIndex = 7;
            this.clicksLabel.Text = "0";
            // 
            // basicBakerButton
            // 
            this.basicBakerButton.Enabled = false;
            this.basicBakerButton.Location = new System.Drawing.Point(51, 125);
            this.basicBakerButton.Name = "basicBakerButton";
            this.basicBakerButton.Size = new System.Drawing.Size(109, 35);
            this.basicBakerButton.TabIndex = 8;
            this.basicBakerButton.TabStop = false;
            this.basicBakerButton.Text = "Buy Basic Baker";
            this.basicBakerButton.UseVisualStyleBackColor = true;
            this.basicBakerButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.basicBakerButton_MouseDown);
            // 
            // basicBakerPowerIncrease
            // 
            this.basicBakerPowerIncrease.AutoSize = true;
            this.basicBakerPowerIncrease.Location = new System.Drawing.Point(166, 147);
            this.basicBakerPowerIncrease.Name = "basicBakerPowerIncrease";
            this.basicBakerPowerIncrease.Size = new System.Drawing.Size(35, 13);
            this.basicBakerPowerIncrease.TabIndex = 9;
            this.basicBakerPowerIncrease.Text = "+- c/s";
            // 
            // basicBakerCount
            // 
            this.basicBakerCount.AutoSize = true;
            this.basicBakerCount.Location = new System.Drawing.Point(166, 125);
            this.basicBakerCount.Name = "basicBakerCount";
            this.basicBakerCount.Size = new System.Drawing.Size(13, 13);
            this.basicBakerCount.TabIndex = 10;
            this.basicBakerCount.Text = "0";
            // 
            // basicBakerCost
            // 
            this.basicBakerCost.AutoSize = true;
            this.basicBakerCost.Location = new System.Drawing.Point(10, 136);
            this.basicBakerCost.Name = "basicBakerCost";
            this.basicBakerCost.Size = new System.Drawing.Size(10, 13);
            this.basicBakerCost.TabIndex = 11;
            this.basicBakerCost.Text = "-";
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(911, 12);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(77, 36);
            this.aboutButton.TabIndex = 12;
            this.aboutButton.TabStop = false;
            this.aboutButton.Text = "About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(911, 54);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(75, 36);
            this.helpButton.TabIndex = 13;
            this.helpButton.TabStop = false;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(958, 539);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(28, 13);
            this.versionLabel.TabIndex = 14;
            this.versionLabel.Text = "v0.1";
            this.versionLabel.DoubleClick += new System.EventHandler(this.versionLabel_DoubleClick);
            // 
            // croissantImage
            // 
            this.croissantImage.BackgroundImage = global::CroissantClickerWF.Properties.Resources.Croissant_Transparent_PNG;
            this.croissantImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.croissantImage.Location = new System.Drawing.Point(397, 178);
            this.croissantImage.Name = "croissantImage";
            this.croissantImage.Size = new System.Drawing.Size(214, 169);
            this.croissantImage.TabIndex = 0;
            this.croissantImage.TabStop = false;
            this.croissantImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Croissant_OnClick);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(913, 205);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 36);
            this.saveButton.TabIndex = 0;
            this.saveButton.TabStop = false;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.saveButton_MouseUp);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(911, 96);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 36);
            this.loadButton.TabIndex = 16;
            this.loadButton.TabStop = false;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(911, 138);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 36);
            this.resetButton.TabIndex = 17;
            this.resetButton.TabStop = false;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(231)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(1000, 561);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.basicBakerCost);
            this.Controls.Add(this.basicBakerCount);
            this.Controls.Add(this.basicBakerPowerIncrease);
            this.Controls.Add(this.basicBakerButton);
            this.Controls.Add(this.clicksLabel);
            this.Controls.Add(this.rateLabel);
            this.Controls.Add(this.croissantsLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.croissantImage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1016, 600);
            this.MinimumSize = new System.Drawing.Size(1016, 600);
            this.Name = "MainForm";
            this.Text = "Croissant Clicker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.croissantImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox croissantImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label croissantsLabel;
        private System.Windows.Forms.Label rateLabel;
        private System.Windows.Forms.Label clicksLabel;

        private ToolTip basicBakerToolTip = new ToolTip();
        public string basicBakerToolTipString = $"{GameData.basicBakers} Basic Bakers are currently baking you {GameData.basicBakers * GameData.basicBakerIncrease} delicious croissants per second";


        public void UpdateLabels()
        {
            clicksLabel.Text = Convert.ToString(GameData.clicks);
            croissantsLabel.Text = Convert.ToString(GameData.Croissants);
            rateLabel.Text = Convert.ToString(GameData.CroissantRate * 5) + "  c/s";
            basicBakerCount.Text = Convert.ToString(GameData.basicBakers);
            basicBakerButton.Enabled = (GameData.Croissants >= GameData.basicBakerCost);
            InitializeToolTips();

        }

        public void UpdatePowerUpLabels()
        {
            basicBakerCost.Text = Convert.ToString(GameData.basicBakerCost);
            basicBakerPowerIncrease.Text = "+" + Convert.ToString(GameData.basicBakerIncrease*5) + " c/s";
        }



        public void OpenCheatsMenu()
        {
            CheatForm cheatForm = new CheatForm();
            cheatForm.ShowDialog();
        }

        private void InitializeToolTips()
        {
            string basicBakerToolTipString = $"{GameData.basicBakers} Basic Bakers are currently baking you {(GameData.basicBakers * GameData.basicBakerIncrease) * 5} delicious croissants per second";
            basicBakerToolTip.SetToolTip(basicBakerPowerIncrease, basicBakerToolTipString);
        }

        public void ChangeBGColor(decimal RValue, decimal GValue, decimal BValue)
        {
            this.BackColor = Color.FromArgb((int)RValue, (int)GValue, (int)BValue);
        }

        private System.Windows.Forms.Button basicBakerButton;
        private System.Windows.Forms.Label basicBakerPowerIncrease;
        private System.Windows.Forms.Label basicBakerCount;
        private System.Windows.Forms.Label basicBakerCost;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.Label versionLabel;
        private Button saveButton;
        private Button loadButton;
        private Button resetButton;
    }
}

