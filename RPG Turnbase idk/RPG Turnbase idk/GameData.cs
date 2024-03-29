using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Turnbase_idk
{
    public class GameData
    {
        //This class sets up separate variables that are used for determining what events to do when in the main forms.
        //Set up private variables
        string playerOneClass = string.Empty;
        string playerTwoClass = string.Empty;
        string currentMonster = "Beowolf";
        string currentGameType = string.Empty;

        //Make private variables available to the rest of the code
        public string PlayerOneClass
        {
            get { return playerOneClass; }
            set { playerOneClass = value; }
        }

        public string PlayerTwoClass
        {
            get { return playerTwoClass; }
            set { playerTwoClass = value; }
        }

        public string CurrentGameType
        {
            get { return currentGameType; }
            set { currentGameType = value; }
        }

        public string CurrentMonster
        {
            get { return currentMonster; }
            set { currentMonster = value; }
        }
    }
}
