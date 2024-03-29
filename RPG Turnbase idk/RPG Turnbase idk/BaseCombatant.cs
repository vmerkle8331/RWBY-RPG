using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Turnbase_idk
{
    class BaseCombatant
    {
        //Set private decimals that are the players attributes
        private decimal healthPoints;
        private decimal maxHealthPoints;
        private decimal attackDamage;
        private decimal defenseAmount;
        private decimal baseDefense;

        string className = string.Empty;

        public string ClassName
        {
            get { return className; }
        }

        public BaseCombatant(decimal hPIn, decimal attackIn, decimal defenseIn) //Constructor takes predetermined values given when creating player objects and sets the decimals above equal to those values.
        {
            maxHealthPoints = hPIn;
            healthPoints = hPIn;
            attackDamage = attackIn;
            baseDefense = defenseIn;
            defenseAmount = defenseIn;
        }

        //Make private decimals available to the rest of the code.
        public decimal DefenseAmount
        {
            get { return defenseAmount; }
            set { defenseAmount = value; }
        }

        public decimal HealthPoints
        {
            get { return healthPoints; }
            set { healthPoints = value; }
        }

        public decimal MaxHealthPoints
        {
            get { return maxHealthPoints; }
            set { maxHealthPoints = value; }
        }

        public decimal AttackDamage
        {
            get { return attackDamage; }
            set { attackDamage = value; }
        }

        public decimal BaseDefense
        {
            get { return baseDefense; }
            set { baseDefense = value; }
        }

        public decimal DealDamage(decimal baseDamage) //This method is used by players and monsters to determine the amount of damage that will be given to one another
        {
            attackDamage = baseDamage * RandomDecimal();
            return (attackDamage);
        }

        public void TakeDamage(decimal damageIn) //This method is used by players and monsters to actually take the damage determined in deal damage
        {
            healthPoints = healthPoints - (damageIn * DefenseAmount);
        }

        public decimal RandomDecimal() //This method makes a random decimal between 1.0 and 1.6 that is used to multiply by base damage of each class so damage amounts arent always the same.
        {
            Random rnd = new Random();
            int num = rnd.Next(10, 16);
            decimal randomDecimal = num / 10;
            return randomDecimal;
        }
    }
}
