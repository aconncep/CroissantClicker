using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CroissantClicker.Common;

namespace CroissantClickerWF
{
    public partial class CheatForm : Form
    {

        public CheatForm()
        {
            InitializeComponent();
        }

        private void applyCheatButton_Click(object sender, EventArgs e)
        {
            if (Cheats.ApplyCheatCode(cheatTextBox.Text))
            {
                this.Dispose();
            }
            else
            {
                invalidErrorLabel.Visible = true;
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            invalidErrorLabel.Visible = false;
            if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }

        private void cheatTextBox_Click(object sender, EventArgs e)
        {
            invalidErrorLabel.Visible = false;
        }
    }
}
