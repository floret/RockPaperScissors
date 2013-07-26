namespace RockPaperScissors
{
    partial class frmRPS
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
            this.cmbPlayerOne = new System.Windows.Forms.ComboBox();
            this.cmbPlayerTwo = new System.Windows.Forms.ComboBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.lvwDisplay = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // cmbPlayerOne
            // 
            this.cmbPlayerOne.FormattingEnabled = true;
            this.cmbPlayerOne.Items.AddRange(new object[] {
            "Rock",
            "Paper",
            "Scissors"});
            this.cmbPlayerOne.Location = new System.Drawing.Point(42, 29);
            this.cmbPlayerOne.Name = "cmbPlayerOne";
            this.cmbPlayerOne.Size = new System.Drawing.Size(121, 21);
            this.cmbPlayerOne.TabIndex = 0;
            this.cmbPlayerOne.SelectedIndexChanged += new System.EventHandler(this.cmbPlayerOne_SelectedIndexChanged);
            // 
            // cmbPlayerTwo
            // 
            this.cmbPlayerTwo.FormattingEnabled = true;
            this.cmbPlayerTwo.Items.AddRange(new object[] {
            "Rock",
            "Paper",
            "Scissors"});
            this.cmbPlayerTwo.Location = new System.Drawing.Point(188, 29);
            this.cmbPlayerTwo.Name = "cmbPlayerTwo";
            this.cmbPlayerTwo.Size = new System.Drawing.Size(121, 21);
            this.cmbPlayerTwo.TabIndex = 1;
            this.cmbPlayerTwo.SelectedIndexChanged += new System.EventHandler(this.cmbPlayerTwo_SelectedIndexChanged);
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(140, 296);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 3;
            this.btnGo.Text = "Go!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // lvwDisplay
            // 
            this.lvwDisplay.Location = new System.Drawing.Point(42, 67);
            this.lvwDisplay.Name = "lvwDisplay";
            this.lvwDisplay.Size = new System.Drawing.Size(267, 202);
            this.lvwDisplay.TabIndex = 4;
            this.lvwDisplay.UseCompatibleStateImageBehavior = false;
            this.lvwDisplay.View = System.Windows.Forms.View.List;
            // 
            // frmRPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 331);
            this.Controls.Add(this.lvwDisplay);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.cmbPlayerTwo);
            this.Controls.Add(this.cmbPlayerOne);
            this.Name = "frmRPS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock     |     Paper     |     Scissors";
            this.Load += new System.EventHandler(this.frmRPS_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPlayerOne;
        private System.Windows.Forms.ComboBox cmbPlayerTwo;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.ListView lvwDisplay;

    }
}

