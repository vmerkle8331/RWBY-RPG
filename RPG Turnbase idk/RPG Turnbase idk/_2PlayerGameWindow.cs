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
    public partial class _2PlayerGameWindow : Form
    {
        //When the window is opened, all neccesary objects are created for reference later.

        Beowolf beowolf = new Beowolf(100, 25, 0.7m);
        Boarbatusk boarbatusk = new Boarbatusk(125, 50, 0.5m);
        DeathStalker deathStalker = new DeathStalker(100, 35, 0.6m);
        Nevermore nevermore = new Nevermore(250, 50, 0.4m);

        Weiss weiss = new Weiss(125, 50, 0.7m);
        Yang yang = new Yang(200, 50, 0.7m);
        Ruby ruby = new Ruby(175, 65, 0.6m);
        Blake blake = new Blake(150, 50, 0.7m);

        Weiss weissPlayer2 = new Weiss(125, 50, 0.7m);
        Yang yangPlayer2 = new Yang(200, 50, 0.7m);
        Ruby rubyPlayer2 = new Ruby(175, 65, 0.6m);
        Blake blakePlayer2 = new Blake(150, 50, 0.7m);

        GameData currentGameData = new GameData();
        public _2PlayerGameWindow() //This is just the primary method that creates the form, gets the player classes and sets up the players
        {
            InitializeComponent();
            currentGameData = MenuWindow.NewGameData;
            FillActionBox();
        }



        void FillActionBox() //This method fills the player's action boxes based on the class they have chosen.
        {
            MonsterPics.Image = imageList1.Images[0];
            TurnResultTextBox.Text = "Its a beowolf! Get ready to fight!";
            TurnResultTextBox.Text = Environment.NewLine;
            monsterHealthLabel.Text = "HP: " + beowolf.HealthPoints + "/" + beowolf.MaxHealthPoints;

            switch (currentGameData.PlayerOneClass)
            {

                case "Yang":
                    {
                        playerHealthLabel.Text = "Player 1 Aura: " + yang.HealthPoints + "/" + yang.MaxHealthPoints;
                        PlayerPics.Image = imageList1.Images[7];
                        actionSelectionComboBox.Items.Add("Gauntlets");
                        actionSelectionComboBox.Items.Add("Shotgun");
                        actionSelectionComboBox.Items.Add("Burn");
                        break;
                    }
                case "Blake":
                    {
                        playerHealthLabel.Text = "Player 1 Aura: " + blake.HealthPoints + "/" + blake.MaxHealthPoints;
                        PlayerPics.Image = imageList1.Images[1];
                        actionSelectionComboBox.Items.Add("Katanna");
                        actionSelectionComboBox.Items.Add("Gun");
                        actionSelectionComboBox.Items.Add("Shadow");
                        break;
                    }
                case "Weiss":
                    {
                        playerHealthLabel.Text = "Player 1 Aura: " + weiss.HealthPoints + "/" + weiss.MaxHealthPoints;
                        PlayerPics.Image = imageList1.Images[6];
                        actionSelectionComboBox.Items.Add("Rapier");
                        actionSelectionComboBox.Items.Add("Revolver");
                        actionSelectionComboBox.Items.Add("Glyphs");
                        break;
                    }
                case "Ruby":
                    {
                        playerHealthLabel.Text = "Player 1 Aura: " + ruby.HealthPoints + "/" + ruby.MaxHealthPoints;
                        PlayerPics.Image = imageList1.Images[5];
                        actionSelectionComboBox.Items.Add("Scythe");
                        actionSelectionComboBox.Items.Add("Sniper-Rifle");
                        actionSelectionComboBox.Items.Add("Petal Burst");
                        break;
                    }
            }

            switch (currentGameData.PlayerTwoClass)
            {

                case "Yang":
                    {
                        player2HealthLabel.Text = "Player 2 Aura: " + yangPlayer2.HealthPoints + "/" + yangPlayer2.MaxHealthPoints;
                        Player2Pics.Image = imageList1.Images[7];
                        action2SelectionComboBox.Items.Add("Gauntlets");
                        action2SelectionComboBox.Items.Add("Shotgun");
                        action2SelectionComboBox.Items.Add("Burn");
                        break;
                    }
                case "Blake":
                    {
                        player2HealthLabel.Text = "Player 2 Aura: " + blakePlayer2.HealthPoints + "/" + blakePlayer2.MaxHealthPoints;
                        Player2Pics.Image = imageList1.Images[1];
                        action2SelectionComboBox.Items.Add("Katanna");
                        action2SelectionComboBox.Items.Add("Gun");
                        action2SelectionComboBox.Items.Add("Shadow");
                        break;
                    }
                case "Weiss":
                    {
                        player2HealthLabel.Text = "Player 2 Aura: " + weissPlayer2.HealthPoints + "/" + weissPlayer2.MaxHealthPoints;
                        Player2Pics.Image = imageList1.Images[6];
                        action2SelectionComboBox.Items.Add("Rapier");
                        action2SelectionComboBox.Items.Add("Revolver");
                        action2SelectionComboBox.Items.Add("Glyphs");
                        break;
                    }
                case "Ruby":
                    {
                        player2HealthLabel.Text = "Player 2 Aura: " + rubyPlayer2.HealthPoints + "/" + rubyPlayer2.MaxHealthPoints;
                        Player2Pics.Image = imageList1.Images[5];
                        action2SelectionComboBox.Items.Add("Scythe");
                        action2SelectionComboBox.Items.Add("Sniper-Rifle");
                        action2SelectionComboBox.Items.Add("Petal Burst");
                        break;
                    }
            }


        }

        public void CheckPlayerHP(GameData currentData) //This method checks both players health to see if they are dead after the turn or not.
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

            switch (currentData.PlayerTwoClass)
            {
                case "Blake":
                    {
                        if (blakePlayer2.HealthPoints <= 0)
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
                        if (rubyPlayer2.HealthPoints <= 0)
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
                        if (weissPlayer2.HealthPoints <= 0)
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
                        if (yangPlayer2.HealthPoints <= 0)
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
                            monsterHealthLabel.Text = "Grimm HP: " + boarbatusk.HealthPoints + "/" + boarbatusk.MaxHealthPoints;
                            //wizardPlayer.Mana += 600;
                            //wizardPlayer2.Mana += 600;
                            break;
                        }
                        else
                        {
                            monsterHealthLabel.Text = "Grimm HP: " + Math.Round(beowolf.HealthPoints) + "/" + beowolf.MaxHealthPoints;
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
                            monsterHealthLabel.Text = "Grimm HP: " + deathStalker.HealthPoints + "/" + deathStalker.MaxHealthPoints;
                            //wizardPlayer.Mana += 600;
                            //wizardPlayer2.Mana += 600;
                            break;
                        }
                        else
                        {
                            monsterHealthLabel.Text = "Grimm HP: " + Math.Round(boarbatusk.HealthPoints) + "/" + boarbatusk.MaxHealthPoints;
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
                            monsterHealthLabel.Text = "Grimm HP: " + nevermore.HealthPoints + "/" + nevermore.MaxHealthPoints;
                            //wizardPlayer.Mana += 600;
                            //wizardPlayer2.Mana += 600;
                            break;
                        }
                        else
                        {
                            monsterHealthLabel.Text = "Grimm HP: " + Math.Round(deathStalker.HealthPoints) + "/" + deathStalker.MaxHealthPoints;

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
                            monsterHealthLabel.Text = "Grimm HP: " + Math.Round(nevermore.HealthPoints) + "/" + nevermore.MaxHealthPoints;
                            break;
                        }
                    }
            }


        }

        public void ShowDamageTaken(decimal damageIn) //This is a simple method that just puts the hp of the players and monsters on the form and updates them as health is taken or added.
        {
            switch (currentGameData.PlayerOneClass)
            {
                case "Blake":
                    {
                        decimal damageTaken = damageIn * blake.DefenseAmount;
                        TurnResultTextBox.Text += Environment.NewLine + "Player 1 took " + Math.Round(damageTaken) + " damage.";
                        playerHealthLabel.Text = "Player 1 Aura: " + Math.Round(blake.HealthPoints) + "/" + blake.MaxHealthPoints;
                        break;
                    }
                case "Ruby":
                    {
                        decimal damageTaken = damageIn * ruby.DefenseAmount;
                        TurnResultTextBox.Text += Environment.NewLine + "Player 1 took " + Math.Round(damageTaken) + " damage.";
                        playerHealthLabel.Text = "Player 1 HP: " + Math.Round(ruby.HealthPoints) + "/" + ruby.MaxHealthPoints;
                        break;
                    }
                case "Weiss":
                    {
                        decimal damageTaken = damageIn * weiss.DefenseAmount;
                        TurnResultTextBox.Text += Environment.NewLine + "Player 1 took " + Math.Round(damageTaken) + " damage.";
                        playerHealthLabel.Text = "Player 1 HP: " + Math.Round(weiss.HealthPoints) + "/" + weiss.MaxHealthPoints;
                        break;
                    }
                case "Yang":
                    {
                        decimal damageTaken = damageIn * yang.DefenseAmount;
                        TurnResultTextBox.Text += Environment.NewLine + "Player 1 took " + Math.Round(damageTaken) + " damage.";
                        playerHealthLabel.Text = "Player 1 HP: " + Math.Round( yang.HealthPoints) + "/" + yang.MaxHealthPoints;
                        break;
                    }
            }

            switch (currentGameData.PlayerTwoClass)
            {
                case "Blake":
                    {
                        decimal damageTaken = damageIn * blakePlayer2.DefenseAmount;
                        TurnResultTextBox.Text += Environment.NewLine + "Player 2 took " + Math.Round(damageTaken) + " damage.";
                        player2HealthLabel.Text = "Player 2 HP: " + Math.Round(blakePlayer2.HealthPoints) + "/" + blakePlayer2.MaxHealthPoints;
                        break;
                    }
                case "Ruby":
                    {
                        decimal damageTaken = damageIn * rubyPlayer2.DefenseAmount;
                        TurnResultTextBox.Text += Environment.NewLine + "Player 2 took " + Math.Round(damageTaken) + " damage.";
                        player2HealthLabel.Text = "Player 2 HP: " + Math.Round(rubyPlayer2.HealthPoints) + "/" + rubyPlayer2.MaxHealthPoints;
                        break;
                    }
                case "Weiss":
                    {
                        decimal damageTaken = damageIn * weissPlayer2.DefenseAmount;
                        TurnResultTextBox.Text += Environment.NewLine + "Player 2 took " + Math.Round(damageTaken) + " damage.";
                        player2HealthLabel.Text = "Player 2 HP: " + Math.Round(weissPlayer2.HealthPoints) + "/" + weissPlayer2.MaxHealthPoints;
                        break;
                    }
                case "Yang":
                    {
                        decimal damageTaken = damageIn * yangPlayer2.DefenseAmount;
                        TurnResultTextBox.Text += Environment.NewLine + "Player 2 took " + Math.Round(damageTaken) + " damage.";
                        player2HealthLabel.Text = "Player 2 HP: " + Math.Round(yangPlayer2.HealthPoints) + "/" + yang.MaxHealthPoints;
                        break;
                    }
            }
        }

        private void startTurnButton_Click(object sender, EventArgs e) //This method is the one that does most of the work. It determines attacks used and applies damage and debuffs accordingly.
        {
            //Set starting damage amounts to be used later
            decimal totalMonsterDamage = 0;
            decimal tempPlayerDamage = 0;
            decimal totalPlayerDamage = 0;
            decimal totalPlayer2Damage = 0;

            //Tests whether the users have selected an action and displays a message if they havent
            if (actionSelectionComboBox.Text == "")
            {
                MessageBox.Show("Please select an action before proceeding");
            }
            else if (action2SelectionComboBox.Text == "")
            {
                MessageBox.Show("Please select an action before proceeding");
            }
            else
            {
                switch (currentGameData.CurrentMonster) //Randomly chooses one of the attacks from the monsters choices of attacks
                {
                    case "Beowolf":
                        {
                            tempPlayerDamage += beowolf.DoAction(currentGameData, ruby, weiss, blake, yang, yangPlayer2, blakePlayer2, weissPlayer2, rubyPlayer2, MenuWindow.SinglePlayerGame, this);
                            totalPlayerDamage += tempPlayerDamage;
                            totalPlayer2Damage += tempPlayerDamage;
                            break;
                        }
                    case "Boarbatusk":
                        {
                            tempPlayerDamage += boarbatusk.DoAction(currentGameData, ruby, weiss, blake, yang, yangPlayer2, blakePlayer2, weissPlayer2, rubyPlayer2, MenuWindow.SinglePlayerGame, this);
                            totalPlayerDamage += tempPlayerDamage;
                            totalPlayer2Damage += tempPlayerDamage;
                            break;
                        }
                    case "Death Stalker":
                        {
                            tempPlayerDamage += deathStalker.DoAction(currentGameData, ruby, weiss, blake, yang, yangPlayer2, blakePlayer2, weissPlayer2, rubyPlayer2, MenuWindow.SinglePlayerGame, this);
                            totalPlayerDamage += tempPlayerDamage;
                            totalPlayer2Damage += tempPlayerDamage;
                            break;
                        }
                    case "Nevermore":
                        {
                            tempPlayerDamage += nevermore.DoAction(currentGameData, ruby, weiss, blake, yang, yangPlayer2, blakePlayer2, weissPlayer2, rubyPlayer2, MenuWindow.SinglePlayerGame, this);
                            totalPlayerDamage += tempPlayerDamage;
                            totalPlayer2Damage += tempPlayerDamage;
                            break;
                        }
                }

                switch (currentGameData.PlayerOneClass) //Takes the action chosen by the 1st player and deals damage or does buffs/debuffs
                {
                    case "Yang":
                        {
                            totalMonsterDamage += yang.DoAction(actionSelectionComboBox.Text, currentGameData, nevermore, deathStalker, boarbatusk, beowolf, yang, weiss, ruby, blake, MenuWindow.SinglePlayerGame, this);
                            break;
                        }
                    case "Blake":
                        {
                            totalMonsterDamage += blake.DoAction(actionSelectionComboBox.Text, currentGameData, nevermore, deathStalker, boarbatusk, beowolf, yang, weiss, ruby, blake, MenuWindow.SinglePlayerGame, this);
                            break;
                        }
                    case "Weiss":
                        {
                            totalMonsterDamage += weiss.DoAction(actionSelectionComboBox.Text, currentGameData, nevermore, deathStalker, boarbatusk, beowolf, yang, weiss, ruby, blake, MenuWindow.SinglePlayerGame, this);
                            break;
                        }
                    case "Ruby":
                        {
                            totalMonsterDamage += ruby.DoAction(actionSelectionComboBox.Text, currentGameData, nevermore, deathStalker, boarbatusk, beowolf, yang, weiss, ruby, blake, MenuWindow.SinglePlayerGame, this);
                            break;
                        }
                }

                switch (currentGameData.PlayerTwoClass) //Takes the action chosen by the 2nd player and deals damage or does buffs/debuffs
                {
                    case "Yang":
                        {
                            totalMonsterDamage += yangPlayer2.DoAction(actionSelectionComboBox.Text, currentGameData, nevermore, deathStalker, boarbatusk, beowolf, yang, weiss, ruby, blake, MenuWindow.SinglePlayerGame, this);
                            break;
                        }
                    case "Blake":
                        {
                            totalMonsterDamage += blakePlayer2.DoAction(actionSelectionComboBox.Text, currentGameData, nevermore, deathStalker, boarbatusk, beowolf, yang, weiss, ruby, blake, MenuWindow.SinglePlayerGame, this);
                            break;
                        }
                    case "Weiss":
                        {
                            totalMonsterDamage += weissPlayer2.DoAction(actionSelectionComboBox.Text, currentGameData, nevermore, deathStalker, boarbatusk, beowolf, yang, weiss, ruby, blake, MenuWindow.SinglePlayerGame, this);
                            break;
                        }
                    case "Ruby":
                        {
                            totalMonsterDamage += rubyPlayer2.DoAction(actionSelectionComboBox.Text, currentGameData, nevermore, deathStalker, boarbatusk, beowolf, yang, weiss, ruby, blake, MenuWindow.SinglePlayerGame, this);
                            break;
                        }
                }

                switch (currentGameData.CurrentMonster) //Takes the damage the players are dealing and deals it to the monster
                {
                    case "Beowold":
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

                switch (currentGameData.PlayerOneClass) //Takes the damage the monster is dealing and deals it to the 1st player
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

                switch (currentGameData.PlayerTwoClass) //Takes the damage the monster is dealing and deals it to the 2nd player
                {
                    case "Yang":
                        {
                            yangPlayer2.TakeDamage(totalPlayer2Damage);
                            break;
                        }
                    case "Blake":
                        {
                            blakePlayer2.TakeDamage(totalPlayer2Damage);
                            break;
                        }
                    case "Weiss":
                        {
                            weissPlayer2.TakeDamage(totalPlayer2Damage);
                            break;
                        }
                    case "Ruby":
                        {
                            rubyPlayer2.TakeDamage(totalPlayer2Damage);
                            break;
                        }
                }

                //Updates players health label
                TurnResultTextBox.AppendText(Environment.NewLine);
                ShowDamageTaken(totalPlayerDamage);

                //Checks to see if player or monster died
                CheckMonsterHP(currentGameData);
                CheckPlayerHP(currentGameData);

                //Resets player defense
                yang.DefenseAmount = yang.BaseDefense;
                blake.DefenseAmount = blake.BaseDefense;
                weiss.DefenseAmount = weiss.BaseDefense;
                ruby.DefenseAmount = ruby.BaseDefense;

                yangPlayer2.DefenseAmount = yangPlayer2.BaseDefense;
                blakePlayer2.DefenseAmount = blakePlayer2.BaseDefense;
                weissPlayer2.DefenseAmount = weissPlayer2.BaseDefense;
                rubyPlayer2.DefenseAmount = rubyPlayer2.BaseDefense;
            }
        }
        private void TurnResultTextBox_TextChanged(object sender, EventArgs e) //This is a simple method that just makes it so the text box autoscrolls as turns happen.
        {
            TurnResultTextBox.SelectionStart = TurnResultTextBox.Text.Length;
            TurnResultTextBox.ScrollToCaret();
        }
    }
}
