using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSim_v1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose fighter:\n1. Ryo\n2. Kan");
            string answer = Console.ReadLine();
            Fighter friend;
            Fighter foe;

            if (answer == "1")
            {
                friend = new Ryo();
                foe = new Kan();
                
            } else if (answer == "2")
            {
                friend = new Kan();
                foe = new Ryo();

            } else
            {
                Console.WriteLine("Please answer 1 or 2.");
            }

            while (friend.IsAlive() == true && foe.IsAlive() == true)
            {

            }   
        }
    }
}
