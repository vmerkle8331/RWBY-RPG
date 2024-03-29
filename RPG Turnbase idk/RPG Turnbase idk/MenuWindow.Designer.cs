namespace RPG_Turnbase_idk
{
    partial class MenuWindow
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.player2ClassLabel = new System.Windows.Forms.Label();
            this.player1ClassComboBox = new System.Windows.Forms.ComboBox();
            this.player2ClassComboBox = new System.Windows.Forms.ComboBox();
            this.SecondPlayerSelectionButton = new System.Windows.Forms.Button();
            this.startGameButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.label3.Location = new System.Drawing.Point(235, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 58);
            this.label3.TabIndex = 0;
            this.label3.Text = "RWBY Game";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(356, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Player 1";
            // 
            // player2ClassLabel
            // 
            this.player2ClassLabel.AutoSize = true;
            this.player2ClassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.player2ClassLabel.Location = new System.Drawing.Point(356, 187);
            this.player2ClassLabel.Name = "player2ClassLabel";
            this.player2ClassLabel.Size = new System.Drawing.Size(70, 20);
            this.player2ClassLabel.TabIndex = 2;
            this.player2ClassLabel.Text = "Player 2";
            // 
            // player1ClassComboBox
            // 
            this.player1ClassComboBox.FormattingEnabled = true;
            this.player1ClassComboBox.Items.AddRange(new object[] {
            "Ruby",
            "Weiss",
            "Blake",
            "Yang"});
            this.player1ClassComboBox.Location = new System.Drawing.Point(331, 146);
            this.player1ClassComboBox.Name = "player1ClassComboBox";
            this.player1ClassComboBox.Size = new System.Drawing.Size(121, 24);
            this.player1ClassComboBox.TabIndex = 3;
            // 
            // player2ClassComboBox
            // 
            this.player2ClassComboBox.FormattingEnabled = true;
            this.player2ClassComboBox.Items.AddRange(new object[] {
            "Ruby",
            "Weiss",
            "Blake",
            "Yang"});
            this.player2ClassComboBox.Location = new System.Drawing.Point(331, 210);
            this.player2ClassComboBox.Name = "player2ClassComboBox";
            this.player2ClassComboBox.Size = new System.Drawing.Size(121, 24);
            this.player2ClassComboBox.TabIndex = 4;
            // 
            // SecondPlayerSelectionButton
            // 
            this.SecondPlayerSelectionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondPlayerSelectionButton.Location = new System.Drawing.Point(331, 253);
            this.SecondPlayerSelectionButton.Name = "SecondPlayerSelectionButton";
            this.SecondPlayerSelectionButton.Size = new System.Drawing.Size(121, 46);
            this.SecondPlayerSelectionButton.TabIndex = 7;
            this.SecondPlayerSelectionButton.Text = "2 Player Mode";
            this.SecondPlayerSelectionButton.UseVisualStyleBackColor = true;
            this.SecondPlayerSelectionButton.Click += new System.EventHandler(this.SecondPlayerSelectionButton_Click);
            // 
            // startGameButton
            // 
            this.startGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.startGameButton.Location = new System.Drawing.Point(193, 305);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(142, 71);
            this.startGameButton.TabIndex = 6;
            this.startGameButton.Text = "Start";
            this.startGameButton.UseVisualStyleBackColor = true;
            this.startGameButton.Click += new System.EventHandler(this.startGameButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.exitButton.Location = new System.Drawing.Point(449, 306);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(142, 71);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // MenuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.SecondPlayerSelectionButton);
            this.Controls.Add(this.player2ClassComboBox);
            this.Controls.Add(this.player1ClassComboBox);
            this.Controls.Add(this.player2ClassLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Name = "MenuWindow";
            this.Text = "RWBY Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label player2ClassLabel;
        private System.Windows.Forms.ComboBox player1ClassComboBox;
        private System.Windows.Forms.ComboBox player2ClassComboBox;
        private System.Windows.Forms.Button SecondPlayerSelectionButton;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Button exitButton;
    }
}

