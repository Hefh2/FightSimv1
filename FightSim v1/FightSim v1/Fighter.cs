using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSim_v1
{
    class Fighter
    {
        protected int hp = 100;
        protected int damage = 20;
        public string name = "";
        static Random generator = new Random();

        public string getName()
        {
            return name;
        }

        public int Attack()
        {
            int randomDamage = generator.Next(2, 5);
            return damage * randomDamage;
        }

        public void Block()
        {
            //Will nullify all damage taken.
        }

        public void Hurt(int damageTaken)
        {
            hp = hp - damageTaken;
        }

        public bool IsAlive()
        {
            if (hp > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetHp()
        {
            return hp;  
        }
    }
}
