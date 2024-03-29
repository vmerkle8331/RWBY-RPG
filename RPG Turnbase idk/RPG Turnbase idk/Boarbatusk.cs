using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Turnbase_idk
{
    class Boarbatusk : BaseCombatant
    {
        public Boarbatusk(decimal hPIn, decimal attackIn, decimal defenseIn) //takes in data to make the Boarbatusk enemy
            : base(hPIn, attackIn, defenseIn)
        {

        }

        public decimal Tusks() //basic attack that gives minimal damage
        {
            return DealDamage(AttackDamage);
        }

        public decimal Roll() //second attack that does more damage
        {
            return DealDamage(AttackDamage * 2);

        }
        public decimal DoAction(GameData currentData, Ruby ruby, Weiss weiss, Blake blake, Yang yang, Yang yangPlayer2, Blake blakePlayer2, Weiss weissPlayer2, Ruby rubyPlayer2, GameWindow singlePlayerWindow, _2PlayerGameWindow twoPlayerWindow)
        {
            //random number is given to choose which attack is used
            Random rnd = new Random();
            int num = rnd.Next(1, 3);

            decimal damageTotal = 0;

            switch (num)
            {
                case 1:
                    {
                        damageTotal = Tusks();
                        switch (currentData.CurrentGameType) //text is displayed to tell the user which attack was used
                        {
                            case "1Player":
                                {
                                    singlePlayerWindow.TurnResultTextBox.Text += Environment.NewLine + "The Boarbatusk hit you with it's tusks!";
                                    break;
                                }
                            case "2Player":
                                {
                                    twoPlayerWindow.TurnResultTextBox.Text += Environment.NewLine + "The Boarbatusk hit you with it's tusks!";
                                    break;
                                }
                        }
                        break;
                    }
                case 2:
                    damageTotal = Roll();
                    switch (currentData.CurrentGameType)//tells user which attacked was used
                    {
                        case "1Player":
                            {
                                singlePlayerWindow.TurnResultTextBox.Text += Environment.NewLine + "The Boarbatusk rolled into you!";
                                break;
                            }
                        case "2Player":
                            {
                                twoPlayerWindow.TurnResultTextBox.Text += Environment.NewLine + "The Boarbatusk rolled into you!";
                                break;
                            }
                    }
                    break;
            }



            return damageTotal;
        }
    }
}
