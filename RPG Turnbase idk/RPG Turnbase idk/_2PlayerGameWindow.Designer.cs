namespace RPG_Turnbase_idk
{
    partial class _2PlayerGameWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_2PlayerGameWindow));
            this.PlayerPics = new System.Windows.Forms.PictureBox();
            this.Player2Pics = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.MonsterPics = new System.Windows.Forms.PictureBox();
            this.monsterHealthLabel = new System.Windows.Forms.Label();
            this.player2HealthLabel = new System.Windows.Forms.Label();
            this.playerHealthLabel = new System.Windows.Forms.Label();
            this.TurnResultTextBox = new System.Windows.Forms.TextBox();
            this.player1ActionLabel = new System.Windows.Forms.Label();
            this.player2ActionLabel = new System.Windows.Forms.Label();
            this.actionSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.action2SelectionComboBox = new System.Windows.Forms.ComboBox();
            this.startTurnButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Pics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonsterPics)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerPics
            // 
            this.PlayerPics.Location = new System.Drawing.Point(545, 36);
            this.PlayerPics.Name = "PlayerPics";
            this.PlayerPics.Size = new System.Drawing.Size(360, 244);
            this.PlayerPics.TabIndex = 0;
            this.PlayerPics.TabStop = false;
            // 
            // Player2Pics
            // 
            this.Player2Pics.Location = new System.Drawing.Point(920, 36);
            this.Player2Pics.Name = "Player2Pics";
            this.Player2Pics.Size = new System.Drawing.Size(360, 244);
            this.Player2Pics.TabIndex = 1;
            this.Player2Pics.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "beowolf.png");
            this.imageList1.Images.SetKeyName(1, "blake.png");
            this.imageList1.Images.SetKeyName(2, "boarbatusk.png");
            this.imageList1.Images.SetKeyName(3, "deathstalker.png");
            this.imageList1.Images.SetKeyName(4, "nevermore.png");
            this.imageList1.Images.SetKeyName(5, "ruby.png");
            this.imageList1.Images.SetKeyName(6, "weiss.png");
            this.imageList1.Images.SetKeyName(7, "yang.png");
            // 
            // MonsterPics
            // 
            this.MonsterPics.Location = new System.Drawing.Point(66, 36);
            this.MonsterPics.Name = "MonsterPics";
            this.MonsterPics.Size = new System.Drawing.Size(360, 244);
            this.MonsterPics.TabIndex = 2;
            this.MonsterPics.TabStop = false;
            // 
            // monsterHealthLabel
            // 
            this.monsterHealthLabel.AutoSize = true;
            this.monsterHealthLabel.Location = new System.Drawing.Point(111, 298);
            this.monsterHealthLabel.Name = "monsterHealthLabel";
            this.monsterHealthLabel.Size = new System.Drawing.Size(0, 17);
            this.monsterHealthLabel.TabIndex = 3;
            // 
            // player2HealthLabel
            // 
            this.player2HealthLabel.AutoSize = true;
            this.player2HealthLabel.Location = new System.Drawing.Point(1029, 301);
            this.player2HealthLabel.Name = "player2HealthLabel";
            this.player2HealthLabel.Size = new System.Drawing.Size(0, 17);
            this.player2HealthLabel.TabIndex = 4;
            // 
            // playerHealthLabel
            // 
            this.playerHealthLabel.AutoSize = true;
            this.playerHealthLabel.Location = new System.Drawing.Point(696, 299);
            this.playerHealthLabel.Name = "playerHealthLabel";
            this.playerHealthLabel.Size = new System.Drawing.Size(0, 17);
            this.playerHealthLabel.TabIndex = 5;
            // 
            // TurnResultTextBox
            // 
            this.TurnResultTextBox.Location = new System.Drawing.Point(545, 330);
            this.TurnResultTextBox.Multiline = true;
            this.TurnResultTextBox.Name = "TurnResultTextBox";
            this.TurnResultTextBox.ReadOnly = true;
            this.TurnResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TurnResultTextBox.Size = new System.Drawing.Size(735, 112);
            this.TurnResultTextBox.TabIndex = 6;
            // 
            // player1ActionLabel
            // 
            this.player1ActionLabel.AutoSize = true;
            this.player1ActionLabel.Location = new System.Drawing.Point(668, 458);
            this.player1ActionLabel.Name = "player1ActionLabel";
            this.player1ActionLabel.Size = new System.Drawing.Size(103, 17);
            this.player1ActionLabel.TabIndex = 7;
            this.player1ActionLabel.Text = "Player 1 Action";
            // 
            // player2ActionLabel
            // 
            this.player2ActionLabel.AutoSize = true;
            this.player2ActionLabel.Location = new System.Drawing.Point(1058, 458);
            this.player2ActionLabel.Name = "player2ActionLabel";
            this.player2ActionLabel.Size = new System.Drawing.Size(103, 17);
            this.player2ActionLabel.TabIndex = 8;
            this.player2ActionLabel.Text = "Player 2 Action";
            // 
            // actionSelectionComboBox
            // 
            this.actionSelectionComboBox.FormattingEnabled = true;
            this.actionSelectionComboBox.Location = new System.Drawing.Point(545, 488);
            this.actionSelectionComboBox.Name = "actionSelectionComboBox";
            this.actionSelectionComboBox.Size = new System.Drawing.Size(360, 24);
            this.actionSelectionComboBox.TabIndex = 9;
            // 
            // action2SelectionComboBox
            // 
            this.action2SelectionComboBox.FormattingEnabled = true;
            this.action2SelectionComboBox.Location = new System.Drawing.Point(920, 488);
            this.action2SelectionComboBox.Name = "action2SelectionComboBox";
            this.action2SelectionComboBox.Size = new System.Drawing.Size(360, 24);
            this.action2SelectionComboBox.TabIndex = 10;
            // 
            // startTurnButton
            // 
            this.startTurnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.startTurnButton.Location = new System.Drawing.Point(95, 381);
            this.startTurnButton.Name = "startTurnButton";
            this.startTurnButton.Size = new System.Drawing.Size(257, 94);
            this.startTurnButton.TabIndex = 11;
            this.startTurnButton.Text = "Attack";
            this.startTurnButton.UseVisualStyleBackColor = true;
            this.startTurnButton.Click += new System.EventHandler(this.startTurnButton_Click);
            // 
            // _2PlayerGameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 566);
            this.Controls.Add(this.startTurnButton);
            this.Controls.Add(this.action2SelectionComboBox);
            this.Controls.Add(this.actionSelectionComboBox);
            this.Controls.Add(this.player2ActionLabel);
            this.Controls.Add(this.player1ActionLabel);
            this.Controls.Add(this.TurnResultTextBox);
            this.Controls.Add(this.playerHealthLabel);
            this.Controls.Add(this.player2HealthLabel);
            this.Controls.Add(this.monsterHealthLabel);
            this.Controls.Add(this.MonsterPics);
            this.Controls.Add(this.Player2Pics);
            this.Controls.Add(this.PlayerPics);
            this.Name = "_2PlayerGameWindow";
            this.Text = "RWBY Game";
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Pics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonsterPics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PlayerPics;
        private System.Windows.Forms.PictureBox Player2Pics;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox MonsterPics;
        private System.Windows.Forms.Label monsterHealthLabel;
        private System.Windows.Forms.Label player2HealthLabel;
        private System.Windows.Forms.Label playerHealthLabel;
        private System.Windows.Forms.Label player1ActionLabel;
        private System.Windows.Forms.Label player2ActionLabel;
        private System.Windows.Forms.ComboBox actionSelectionComboBox;
        private System.Windows.Forms.ComboBox action2SelectionComboBox;
        private System.Windows.Forms.Button startTurnButton;
        public System.Windows.Forms.TextBox TurnResultTextBox;
    }
}