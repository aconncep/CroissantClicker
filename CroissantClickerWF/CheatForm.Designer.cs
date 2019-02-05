namespace CroissantClickerWF
{
    partial class CheatForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cheatTextBox = new System.Windows.Forms.TextBox();
            this.applyCheatButton = new System.Windows.Forms.Button();
            this.invalidErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1 
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Cheat Code:";
            // 
            // cheatTextBox
            // 
            this.cheatTextBox.Location = new System.Drawing.Point(12, 37);
            this.cheatTextBox.Name = "cheatTextBox";
            this.cheatTextBox.Size = new System.Drawing.Size(241, 20);
            this.cheatTextBox.TabIndex = 1;
            this.cheatTextBox.Click += new System.EventHandler(this.cheatTextBox_Click);
            this.cheatTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // applyCheatButton
            // 
            this.applyCheatButton.Location = new System.Drawing.Point(259, 32);
            this.applyCheatButton.Name = "applyCheatButton";
            this.applyCheatButton.Size = new System.Drawing.Size(75, 29);
            this.applyCheatButton.TabIndex = 2;
            this.applyCheatButton.Text = "Apply";
            this.applyCheatButton.UseVisualStyleBackColor = true;
            this.applyCheatButton.Click += new System.EventHandler(this.applyCheatButton_Click);
            // 
            // invalidErrorLabel
            // 
            this.invalidErrorLabel.AutoSize = true;
            this.invalidErrorLabel.ForeColor = System.Drawing.Color.Crimson;
            this.invalidErrorLabel.Location = new System.Drawing.Point(240, 12);
            this.invalidErrorLabel.Name = "invalidErrorLabel";
            this.invalidErrorLabel.Size = new System.Drawing.Size(94, 13);
            this.invalidErrorLabel.TabIndex = 3;
            this.invalidErrorLabel.Text = "invalid cheat code";
            this.invalidErrorLabel.Visible = false;
            // 
            // CheatForm
            // 
            this.AcceptButton = this.applyCheatButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 79);
            this.Controls.Add(this.invalidErrorLabel);
            this.Controls.Add(this.applyCheatButton);
            this.Controls.Add(this.cheatTextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(362, 118);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(362, 118);
            this.Name = "CheatForm";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cheat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cheatTextBox;
        private System.Windows.Forms.Button applyCheatButton;
        private System.Windows.Forms.Label invalidErrorLabel;
    }
}