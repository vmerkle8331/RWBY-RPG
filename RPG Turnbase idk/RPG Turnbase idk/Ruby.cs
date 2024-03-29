using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Turnbase_idk
{
    class Ruby : BaseCombatant
    {
        public Ruby(decimal hPIn, decimal attackIn, decimal defenseIn) //takes in data to make Ruby
            : base(hPIn, attackIn, defenseIn)
        {

        }
        private int amountOfDust = 10; //uses variable to limit how many times a player can use these attacks
        private int semblencePower = 0;

        string className = "Ruby";

        public string ClassName
        {
            get { return className; }
        }

        public decimal Scythe() //basic attack that doesn't use any of the variables and causes minimal damage
        {
            return DealDamage(AttackDamage);
        }
        public decimal SniperRifle(GameWindow singlePlayerWindow, _2PlayerGameWindow twoPlayerWindow) //attack that uses the dust variable and causes more damage than stab if out of dust attack fails
        {
            if (amountOfDust > 0)
            {
                amountOfDust--;

                return DealDamage(AttackDamage * 1.5m);
            }
            else
            {// If the Ruby doesn't have enough Dust, text is displayed to notify the player.

                twoPlayerWindow.TurnResultTextBox.Text += Environment.NewLine + "You don't have enough Dust!";
                singlePlayerWindow.TurnResultTextBox.Text += Environment.NewLine + "You don't have enough Dust!";
                return 0;
            }
        }

        //attack that lowers the monster's defense and uses the bomb variable if out of bombs attack fails
        public decimal PetalBurst(GameWindow singlePlayerWindow, _2PlayerGameWindow twoPlayerWindow)
        {
            if (semblencePower < 15)
            {
                semblencePower = 0;

                return DealDamage(AttackDamage * 2m);
            }
            else
            {// If the Ruby doesn't have enough Semblece Power, text is displayed to notify the player.

                twoPlayerWindow.TurnResultTextBox.Text += Environment.NewLine + "Your semblence isn't charged!";
                singlePlayerWindow.TurnResultTextBox.Text += Environment.NewLine + "Your semblenced isn't charged!";
                return semblencePower;
            }
        }

        public decimal DoAction(string actionName, GameData currentData, Nevermore nevermore, DeathStalker deathStalker, Boarbatusk boarbatusk, Beowolf beowolf, Yang yang, Weiss weiss, Ruby ruby, Blake blake, GameWindow singlePlayerWindow, _2PlayerGameWindow twoPlayerWindow)
        {
            //variable damageTotal is created to store the total amount of damage the rogue will do this turn. 
            decimal damageTotal = 0;
            switch (actionName)
            {
                //Gets user's selection from the drop down menu 
                case "Scythe":
                    {
                        damageTotal = Scythe();
                        return damageTotal;
                    }
                case "Sniper-Rifle":
                    {
                        damageTotal = SniperRifle(singlePlayerWindow, twoPlayerWindow);
                        return damageTotal;
                    }
                case "Petal Burst":
                    {
                        damageTotal = PetalBurst(singlePlayerWindow, twoPlayerWindow);
                        return damageTotal;
                    }
                default:
                    {
                        return damageTotal;
                    }
            }

        }
    }
}
