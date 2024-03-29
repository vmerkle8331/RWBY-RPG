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
    public partial class MenuWindow : Form
    {
        //Create neccesary objects for later reference and make public properties so they can be accessed throughout the program.
        private static GameData newGameData = new GameData();
        private static GameWindow singlePlayerGame = new GameWindow();
        private static _2PlayerGameWindow twoPlayerGame = new _2PlayerGameWindow();

        //Makes objects available to the rest of the code
        public static GameData NewGameData
        {
            get { return newGameData; }
            set { newGameData = value; }
        }

        public static GameWindow SinglePlayerGame
        {
            get { return singlePlayerGame; }
            set { singlePlayerGame = value; }
        }

        public static _2PlayerGameWindow TwoPlayerGame
        {
            get { return twoPlayerGame; }
            set { twoPlayerGame = value; }
        }

        public MenuWindow() //Opens and sets up the form.
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e) //Exits the form upon clicking the exit button
        {
            this.Close();
        }

        private void startGameButton_Click(object sender, EventArgs e) //Deals with creating single or two player game forms
        {
            //Sets classes in gamedata based on player selections
            newGameData.PlayerOneClass = player1ClassComboBox.Text;
            newGameData.PlayerTwoClass = player2ClassComboBox.Text;

            switch (SecondPlayerSelectionButton.Text) //Checks whether single player or two player is being selected and opens the corresponding window. Also tests to make sure classes are selected.
            {
                case "2 Player Mode"://This is the one player mode
                    if (player1ClassComboBox.Text == "")
                    {
                        MessageBox.Show("Please select a class.");
                    }
                    else
                    {
                        singlePlayerGame = new GameWindow();
                        singlePlayerGame.Show();
                        newGameData.CurrentGameType = "1Player";
                    }
                    break;
                case "1 Player Mode"://This is the two player mode
                    if (player1ClassComboBox.Text == "")
                    {
                        MessageBox.Show("Please select a class.");
                    }
                    else if (player2ClassComboBox.Text == "")
                    {
                        MessageBox.Show("Please select a class.");
                    }
                    else
                    {
                        twoPlayerGame = new _2PlayerGameWindow();
                        twoPlayerGame.Show();
                        newGameData.CurrentGameType = "2Player";
                    }
                    break;
            }

        }

        private void SecondPlayerSelectionButton_Click(object sender, EventArgs e) //Shows or hides corresponding info on menu form regarding single or 2 player mode.
        {
            switch (SecondPlayerSelectionButton.Text)
            {
                case "2 Player Mode"://Shows info for single player game
                    SecondPlayerSelectionButton.Text = "1 Player Mode";
                    player2ClassComboBox.Visible = true;
                    player2ClassLabel.Visible = true;
                    break;

                case "1 Player Mode"://Shows info for two player game
                    SecondPlayerSelectionButton.Text = "2 Player Mode";
                    player2ClassComboBox.Visible = false;
                    player2ClassLabel.Visible = false;
                    break;
            }
        }
    }
}
