namespace RPG_Turnbase_idk
{
    partial class GameWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.MonsterPics = new System.Windows.Forms.PictureBox();
            this.PlayerPics = new System.Windows.Forms.PictureBox();
            this.TurnResultTextBox = new System.Windows.Forms.TextBox();
            this.monsterHealthLabel = new System.Windows.Forms.Label();
            this.playerHealthLabel = new System.Windows.Forms.Label();
            this.actionSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.startTurnButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MonsterPics)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPics)).BeginInit();
            this.SuspendLayout();
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
            this.imageList1.Images.SetKeyName(7, "yangresized.png");
            // 
            // MonsterPics
            // 
            this.MonsterPics.Location = new System.Drawing.Point(86, 36);
            this.MonsterPics.Name = "MonsterPics";
            this.MonsterPics.Size = new System.Drawing.Size(449, 244);
            this.MonsterPics.TabIndex = 0;
            this.MonsterPics.TabStop = false;
            // 
            // PlayerPics
            // 
            this.PlayerPics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlayerPics.BackColor = System.Drawing.Color.Transparent;
            this.PlayerPics.Location = new System.Drawing.Point(809, 36);
            this.PlayerPics.Name = "PlayerPics";
            this.PlayerPics.Size = new System.Drawing.Size(449, 244);
            this.PlayerPics.TabIndex = 1;
            this.PlayerPics.TabStop = false;
            // 
            // TurnResultTextBox
            // 
            this.TurnResultTextBox.Location = new System.Drawing.Point(809, 349);
            this.TurnResultTextBox.Multiline = true;
            this.TurnResultTextBox.Name = "TurnResultTextBox";
            this.TurnResultTextBox.ReadOnly = true;
            this.TurnResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TurnResultTextBox.Size = new System.Drawing.Size(449, 94);
            this.TurnResultTextBox.TabIndex = 3;
            this.TurnResultTextBox.Click += new System.EventHandler(this.TurnResultTextBox_TextChanged);
            // 
            // monsterHealthLabel
            // 
            this.monsterHealthLabel.AutoSize = true;
            this.monsterHealthLabel.Location = new System.Drawing.Point(179, 303);
            this.monsterHealthLabel.Name = "monsterHealthLabel";
            this.monsterHealthLabel.Size = new System.Drawing.Size(0, 17);
            this.monsterHealthLabel.TabIndex = 3;
            // 
            // playerHealthLabel
            // 
            this.playerHealthLabel.AutoSize = true;
            this.playerHealthLabel.Location = new System.Drawing.Point(961, 308);
            this.playerHealthLabel.Name = "playerHealthLabel";
            this.playerHealthLabel.Size = new System.Drawing.Size(0, 17);
            this.playerHealthLabel.TabIndex = 4;
            // 
            // actionSelectionComboBox
            // 
            this.actionSelectionComboBox.FormattingEnabled = true;
            this.actionSelectionComboBox.Location = new System.Drawing.Point(809, 464);
            this.actionSelectionComboBox.Name = "actionSelectionComboBox";
            this.actionSelectionComboBox.Size = new System.Drawing.Size(449, 24);
            this.actionSelectionComboBox.TabIndex = 5;
            // 
            // startTurnButton
            // 
            this.startTurnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.startTurnButton.Location = new System.Drawing.Point(86, 394);
            this.startTurnButton.Name = "startTurnButton";
            this.startTurnButton.Size = new System.Drawing.Size(257, 94);
            this.startTurnButton.TabIndex = 6;
            this.startTurnButton.Text = "Attack";
            this.startTurnButton.UseVisualStyleBackColor = true;
            this.startTurnButton.Click += new System.EventHandler(this.startTurnButton_Click);
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 566);
            this.Controls.Add(this.startTurnButton);
            this.Controls.Add(this.actionSelectionComboBox);
            this.Controls.Add(this.playerHealthLabel);
            this.Controls.Add(this.monsterHealthLabel);
            this.Controls.Add(this.TurnResultTextBox);
            this.Controls.Add(this.PlayerPics);
            this.Controls.Add(this.MonsterPics);
            this.Name = "GameWindow";
            this.Text = "RWBY Game";
            ((System.ComponentModel.ISupportInitialize)(this.MonsterPics)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerPics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox MonsterPics;
        private System.Windows.Forms.PictureBox PlayerPics;
        private System.Windows.Forms.Label monsterHealthLabel;
        private System.Windows.Forms.Label playerHealthLabel;
        private System.Windows.Forms.ComboBox actionSelectionComboBox;
        private System.Windows.Forms.Button startTurnButton;
        public System.Windows.Forms.TextBox TurnResultTextBox;
    }
}