using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPG_Turnbase_idk
{
    public partial class GameWindow : Form
    {

        Beowolf beowolf = new Beowolf(100, 15, 0.7m);
        Boarbatusk boarbatusk = new Boarbatusk(125, 35, 0.5m);
        DeathStalker deathStalker = new DeathStalker(100, 25, 0.5m);
        Nevermore nevermore = new Nevermore(250, 35, 0.4m);

        Weiss weiss = new Weiss(125, 50, 0.8m);
        Yang yang = new Yang(175, 50, 0.7m);
        Ruby ruby = new Ruby(200, 65, 0.6m);
        Blake blake = new Blake(150, 50, 0.7m);

        Weiss weissPlayer2 = new Weiss(125, 50, 0.8m);
        Yang yangPlayer2 = new Yang(200, 50, 0.7m);
        Ruby rubyPlayer2 = new Ruby(175, 65, 0.6m);
        Blake blakePlayer2 = new Blake(150, 50, 0.7m);

        GameData currentGameData = new GameData();

        public GameWindow() //This is just the primary method that creates the form, gets the player class and sets up the player
        {
            InitializeComponent();
            currentGameData = MenuWindow.NewGameData;
            FillActionBox();
        }



        void FillActionBox() //This method fills the player's action boxes based on the class they have chosen.
        {
            MonsterPics.Image = imageList1.Images[0];
            TurnResultTextBox.Text = "Its a beowolf! Get ready to fight!";
            monsterHealthLabel.Text = "HP: " + beowolf.HealthPoints + "/" + beowolf.MaxHealthPoints;

            switch (currentGameData.PlayerOneClass)
            {

                case "Yang":
                    {
                        playerHealthLabel.Text = "Aura: " + yang.HealthPoints + "/" + yang.MaxHealthPoints;
                        PlayerPics.Image = imageList1.Images[7];
                        actionSelectionComboBox.Items.Add("Gauntlets");
                        actionSelectionComboBox.Items.Add("Shotgun");
                        actionSelectionComboBox.Items.Add("Burn");
                        break;
                    }
                case "Blake":
                    {
                        playerHealthLabel.Text = "Aura: " + blake.HealthPoints + "/" + blake.MaxHealthPoints;
                        PlayerPics.Image = imageList1.Images[1];
                        actionSelectionComboBox.Items.Add("Katana");
                        actionSelectionComboBox.Items.Add("Gun");
                        actionSelectionComboBox.Items.Add("Shadow");
                        break;
                    }
                case "Weiss":
                    {
                        playerHealthLabel.Text = "Aura: " + weiss.HealthPoints + "/" + weiss.MaxHealthPoints;
                        PlayerPics.Image = imageList1.Images[6];
                        actionSelectionComboBox.Items.Add("Rapier");
                        actionSelectionComboBox.Items.Add("Revolver");
                        actionSelectionComboBox.Items.Add("Glyphs");
                        break;
                    }
                case "Ruby":
                    {
                        playerHealthLabel.Text = "Aura: " + ruby.HealthPoints + "/" + ruby.MaxHealthPoints;
                        PlayerPics.Image = imageList1.Images[5];
                        actionSelectionComboBox.Items.Add("Scythe");
                        actionSelectionComboBox.Items.Add("Sniper-Rifle");
                        actionSelectionComboBox.Items.Add("Petal Burst");
                        break;
                    }
            }


        }

        private void startTurnButton_Click(object sender, EventArgs e) //This method is the one that does most of the work. It determines attacks used and applies damage and debuffs accordingly.
        {
            //Set starting damage amounts to be used later
            decimal totalMonsterDamage = 0;
            decimal totalPlayerDamage = 0;

            //Tests whether the user has selected an action and displays a message if they havent
            if (actionSelectionComboBox.Text == "")
            {
                MessageBox.Show("Please select an action before proceeding");
            }
            else
            {
                switch (currentGameData.CurrentMonster) //Randomly chooses one of the attacks from the monsters choices of attacks
                {
                    case "Beowolf":
                        {
                            totalPlayerDamage += beowolf.DoAction(currentGameData, ruby, weiss, blake, yang, yangPlayer2, blakePlayer2, weissPlayer2, rubyPlayer2, this, MenuWindow.TwoPlayerGame);
                            ShowDamageTaken(totalPlayerDamage);
                            break;
                        }
                    case "Boarbatusk":
                        {
                            totalPlayerDamage += boarbatusk.DoAction(currentGameData, ruby, weiss, blake, yang, yangPlayer2, blakePlayer2, weissPlayer2, rubyPlayer2, this, MenuWindow.TwoPlayerGame);
                            ShowDamageTaken(totalPlayerDamage);
                            break;
                        }
                    case "Death Stalker":
                        {
                            totalPlayerDamage += deathStalker.DoAction(currentGameData, ruby, weiss, blake, yang, yangPlayer2, blakePlayer2, weissPlayer2, rubyPlayer2, this, MenuWindow.TwoPlayerGame);
                            ShowDamageTaken(totalPlayerDamage);
                            break;
                        }
                    case "Nevermore":
                        {
                            totalPlayerDamage += nevermore.DoAction(currentGameData, ruby, weiss, blake, yang, yangPlayer2, blakePlayer2, weissPlayer2, rubyPlayer2, this, MenuWindow.TwoPlayerGame);
                            ShowDamageTaken(totalPlayerDamage);
                            break;
                        }
                }

                switch (currentGameData.PlayerOneClass) //Takes the action chosen by the player and deals damage or does buffs/debuffs
                {
                    case "Yang":
                        {
                            totalMonsterDamage = yang.DoAction(actionSelectionComboBox.Text, currentGameData, nevermore, deathStalker, boarbatusk, beowolf, yang, weiss, ruby, blake, this, MenuWindow.TwoPlayerGame);
                            break;
                        }
                    case "Blake":
                        {
                            totalMonsterDamage = blake.DoAction(actionSelectionComboBox.Text, currentGameData, nevermore, deathStalker, boarbatusk, beowolf, yang, weiss, ruby, blake, this, MenuWindow.TwoPlayerGame);
                            break;
                        }
                    case "Weiss":
                        {
                            totalMonsterDamage = weiss.DoAction(actionSelectionComboBox.Text, currentGameData, nevermore, deathStalker, boarbatusk, beowolf, yang, weiss, ruby, blake, this, MenuWindow.TwoPlayerGame);
                            break;
                        }
                    case "Ruby":
                        {
                            totalMonsterDamage = ruby.DoAction(actionSelectionComboBox.Text, currentGameData, nevermore, deathStalker, boarbatusk, beowolf, yang, weiss, ruby, blake, this, MenuWindow.TwoPlayerGame);
                            break;
                        }
                }

                switch (currentGameData.CurrentMonster) //Takes the damage the player is dealing and deals it to the monster
                {
                    case "Beowolf":
                        {
                            beowolf.TakeDamage(totalMonsterDamage);
                            break;
                        }
                    case "Boarbatusk":
                        {
                            boarbatusk.TakeDamage(totalMonsterDamage);
                            break;
                        }
                    case "Death Stalker":
                        {
                            deathStalker.TakeDamage(totalMonsterDamage);
                            break;
                        }
                    case "Nevermore":
                        {
                            nevermore.TakeDamage(totalMonsterDamage);
                            break;
                        }
                }

                switch (currentGameData.PlayerOneClass) //Takes the damage the monster is dealing and deals it to the player
                {
                    case "Yang":
                        {
                            yang.TakeDamage(totalPlayerDamage);
                            break;
                        }
                    case "Blake":
                        {
                            blake.TakeDamage(totalPlayerDamage);
                            break;
                        }
                    case "Weiss":
                        {
                            weiss.TakeDamage(totalPlayerDamage);
                            break;
                        }
                    case "Ruby":
                        {
                            ruby.TakeDamage(totalPlayerDamage);
                            break;
                        }
                }

                //Updates players health label
                TurnResultTextBox.AppendText(Environment.NewLine);

                //Checks to see if player or monster died
                CheckMonsterHP(currentGameData);
                CheckPlayerHP(currentGameData);

                //Resets player defense
                ruby.DefenseAmount = ruby.BaseDefense;
                blake.DefenseAmount = blake.BaseDefense;
                weiss.DefenseAmount = weiss.BaseDefense;
                yang.DefenseAmount = yang.BaseDefense;
            }
        }

        public void CheckPlayerHP(GameData currentData) //This method checks the player's health to see if they are dead after the turn or not.
        {
            switch (currentData.PlayerOneClass)
            {
                case "Blake":
                    {
                        if (blake.HealthPoints <= 0)
                        {
                            System.Windows.Forms.MessageBox.Show("You're out of aura!");
                            Application.Restart();
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                case "Ruby":
                    {
                        if (ruby.HealthPoints <= 0)
                        {
                            System.Windows.Forms.MessageBox.Show("You're out of aura!");
                            Application.Restart();
                            break;

                        }
                        else
                        {
                            break;
                        }
                    }
                case "Weiss":
                    {
                        if (weiss.HealthPoints <= 0)
                        {
                            System.Windows.Forms.MessageBox.Show("You're out of aura!");
                            Application.Restart();
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                case "Yang":
                    {
                        if (yang.HealthPoints <= 0)
                        {
                            System.Windows.Forms.MessageBox.Show("You're out of aura!");
                            Application.Restart();
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
            }
        }

        public void CheckMonsterHP(GameData currentData) //This method checks the current monsters health to see if it is dead or not and if so moves on to the next monster.
        {
            switch (currentData.CurrentMonster)
            {
                case "Beowolf":
                    {
                        if (beowolf.HealthPoints <= 0)
                        {
                            MonsterPics.Image = imageList1.Images[2];
                            currentGameData.CurrentMonster = "Boarbatusk";
                            TurnResultTextBox.Text += Environment.NewLine + "You killed the beowolf! \nOh no! A boarbatusk has appeared!";
                            monsterHealthLabel.Text = "HP: " + boarbatusk.HealthPoints + "/" + boarbatusk.MaxHealthPoints;
                            //wizardPlayer.Mana += 600;
                            break;
                        }
                        else
                        {
                            monsterHealthLabel.Text = "HP: " + Math.Round(beowolf.HealthPoints) + "/" + beowolf.MaxHealthPoints;
                            break;
                        }
                    }
                case "Boarbatusk":
                    {
                        if (boarbatusk.HealthPoints <= 0)
                        {
                            MonsterPics.Image = imageList1.Images[3];
                            currentGameData.CurrentMonster = "Death Stalker";
                            TurnResultTextBox.Text += Environment.NewLine + "You killed the boarbatusk! \nOh no! A large death stalker has appeared!";
                            monsterHealthLabel.Text = "HP: " + Math.Round(deathStalker.HealthPoints) + "/" + deathStalker.MaxHealthPoints;
                            //wizardPlayer.Mana += 600;
                            break;
                        }
                        else
                        {
                            monsterHealthLabel.Text = "HP: " + Math.Round(boarbatusk.HealthPoints) + "/" + boarbatusk.MaxHealthPoints;
                            break;
                        }
                    }
                case "Death Stalker":
                    {
                        if (deathStalker.HealthPoints <= 0)
                        {
                            MonsterPics.Image = imageList1.Images[4];
                            currentGameData.CurrentMonster = "Nevermore";
                            TurnResultTextBox.Text += Environment.NewLine + "You killed the death stalker! \nOh no! A giant nevermore has appeared!";
                            monsterHealthLabel.Text = "HP: " + nevermore.HealthPoints + "/" + nevermore.MaxHealthPoints;
                            //wizardPlayer.Mana += 600;
                            break;
                        }
                        else
                        {
                            monsterHealthLabel.Text = "HP: " + Math.Round(deathStalker.HealthPoints) + "/" + deathStalker.MaxHealthPoints;

                            break;
                        }
                    }
                case "Nevermore":
                    {
                        if (nevermore.HealthPoints <= 0)
                        {
                            TurnResultTextBox.Text += Environment.NewLine + "You killed the nevermore and beat the game!";
                            System.Windows.Forms.MessageBox.Show("You killed the nevermore and beat the game!");
                            Application.Restart();
                            break;
                        }
                        else
                        {
                            monsterHealthLabel.Text = "HP: " + Math.Round(nevermore.HealthPoints) + "/" + nevermore.MaxHealthPoints;
                            break;
                        }
                    }
            }


        }

        public void ShowDamageTaken(decimal damageIn) //This is a simple method that just puts the hp of the player and monsters on the form and updates them as health is taken or added.
        {
            switch (currentGameData.PlayerOneClass)
            {
                case "Blake":
                    {
                        decimal damageTaken = damageIn * blake.DefenseAmount;
                        TurnResultTextBox.Text += Environment.NewLine + "You took " + Math.Round(damageTaken) + " damage.";
                        playerHealthLabel.Text = "Aura: " + Math.Round(blake.HealthPoints) + "/" + blake.MaxHealthPoints;
                        break;
                    }
                case "Ruby":
                    {
                        decimal damageTaken = damageIn * ruby.DefenseAmount;
                        TurnResultTextBox.Text += Environment.NewLine + "You took " + Math.Round(damageTaken) + " damage.";
                        playerHealthLabel.Text = "Aura: " + Math.Round(ruby.HealthPoints) + "/" + ruby.MaxHealthPoints;
                        break;
                    }
                case "Weiss":
                    {
                        decimal damageTaken = damageIn * weiss.DefenseAmount;
                        TurnResultTextBox.Text += Environment.NewLine + "You took " + Math.Round(damageTaken) + " damage.";
                        playerHealthLabel.Text = "Aura: " + Math.Round(weiss.HealthPoints) + "/" + weiss.MaxHealthPoints;
                        break;
                    }
                case "Yang":
                    {
                        decimal damageTaken = damageIn * yang.DefenseAmount;
                        TurnResultTextBox.Text += Environment.NewLine + "You took " + Math.Round(damageTaken) + " damage.";
                        playerHealthLabel.Text = "Aura: " + Math.Round(yang.HealthPoints) + "/" + yang.MaxHealthPoints;
                        break;
                    }
            }
        }

        private void TurnResultTextBox_TextChanged(object sender, EventArgs e) //This is a simple method that just makes it so the text box autoscrolls as turns happen.
        {
            TurnResultTextBox.SelectionStart = TurnResultTextBox.Text.Length;
            TurnResultTextBox.ScrollToCaret();
        }
    }
}
