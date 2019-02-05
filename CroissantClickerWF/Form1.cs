using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CroissantClicker.Common;

namespace CroissantClickerWF
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            XMLParser.PopulateGameSettingsFromFile();
            SubscribeUIEvents();
            InitializeToolTips();
            Ticker.TickerStart();
            UIUpdater.InitializePowerUpData();
            
        }

        private void SubscribeUIEvents()
        {
            UIUpdater.UpdateLabelsEvent += UpdateLabels;
            UIUpdater.UpdatePowerUpPricesEvent += UpdatePowerUpLabels;
            UIUpdater.OpenCheatsMenuEvent += OpenCheatsMenu;
        }

        private void Croissant_OnClick(object sender, EventArgs e)
        {
            GameData.IncreaseClicksCount();
            GameData.IncreaseCroissantsCount(GameData.croissantsPerClick);
        }


        private void versionLabel_DoubleClick(object sender, EventArgs e)
        {
            UIUpdater.LaunchCheatsMenu();
        }

        private void basicBakerButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                GameData.BuyBasicBaker(10);
            }
            else
            {
                GameData.BuyBasicBaker();
            }
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There is no help", ":(");
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to restart? You will lose all progress. This cannot be undone.", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (dialogResult == DialogResult.Yes)
            {
                XMLParser.CreateNewGameSave();
                System.Diagnostics.Process.Start(Application.ExecutablePath); // to start new instance of application
                Application.Exit(); //to turn off current app

            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult dialogResult = MessageBox.Show("Do you want to save your game?", "Save game?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    XMLParser.SaveGameData();
                }
                else if (dialogResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }

            }
            
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Croissant_OnClick(null, EventArgs.Empty);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                XMLParser.SaveGameData();
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "XML Files|*.xml";
            openFileDialog.Title = "Select a game settings file";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string strfilename = openFileDialog.FileName;
                XMLParser.OpenGameFromFile(strfilename);
            }
        }

        private void saveButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                XMLParser.SaveGameData();
            }
            else if (e.Button == MouseButtons.Right)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Select a location to save game settings file";
                saveFileDialog.DefaultExt = "XML File|*.xml";
                saveFileDialog.FileName = "GameSettingsCustom.xml";
                saveFileDialog.Filter = "XML Files| *.xml";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string strpathname = saveFileDialog.FileName;
                    XMLParser.CreateNewGameSave(strpathname);
                    
                }
            }
        }
    }
}
