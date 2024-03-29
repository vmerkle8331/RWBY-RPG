using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Turnbase_idk
{
    class DeathStalker : BaseCombatant
    {
        public DeathStalker(decimal hPIn, decimal attackIn, decimal defenseIn) //takes in data to make the Death Stalker enemy
            : base(hPIn, attackIn, defenseIn)
        {

        }

        public decimal Claws() //basic attack that gives minimal damage
        {
            return DealDamage(AttackDamage);
        }

        public decimal Stinger() //second attack that does more damage
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
                        damageTotal = Claws();
                        switch (currentData.CurrentGameType) //text is displayed to tell the user which attack was used
                        {
                            case "1Player":
                                {
                                    singlePlayerWindow.TurnResultTextBox.Text += Environment.NewLine + "The Death Stalker snapped at you with it's claws!";
                                    break;
                                }
                            case "2Player":
                                {
                                    twoPlayerWindow.TurnResultTextBox.Text += Environment.NewLine + "The Death Stalker snapped at you with it's claws!";
                                    break;
                                }
                        }
                        break;
                    }
                case 2:
                    damageTotal = Stinger();
                    switch (currentData.CurrentGameType)//tells user which attacked was used
                    {
                        case "1Player":
                            {
                                singlePlayerWindow.TurnResultTextBox.Text += Environment.NewLine + "The Death Stalker got you with it's stinger!";
                                break;
                            }
                        case "2Player":
                            {
                                twoPlayerWindow.TurnResultTextBox.Text += Environment.NewLine + "The Death Stalker got you with it's stinger!";
                                break;
                            }
                    }
                    break;
            }



            return damageTotal;
        }
    }
}
