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
            Random generator = new Random();

            Console.WriteLine("Choose fighter:\n1. Ryo\n2. Kan");
            Fighter friend = new Fighter();
            Fighter foe = new Fighter();
            bool ryoFriend = false;
            bool repeat = true;

            while (repeat == true)
            {
                string answer = Console.ReadLine();
                Console.Clear();

                if (answer == "1")
                {
                    friend = new Ryo();
                    foe = new Kan();
                    ryoFriend = true;
                    repeat = false;
                }
                else if (answer == "2")
                {
                    friend = new Kan();
                    foe = new Ryo();
                    ryoFriend = false;
                    repeat = false;
                }
                else
                {
                    Console.WriteLine("Please answer 1 or 2.");
                }
            }

            while (friend.IsAlive() == true && foe.IsAlive() == true)
            {
                Console.Clear();
                //Get health and names for both friend and foe.

                Console.WriteLine("Choose your action:\n1. Punch\n2. Block");

                string answer = Console.ReadLine();


                //      den vägrar skriva ut något efter den här readlinen och jag har oavsett inte mer tid att arbeta på projektet så jag stannar här.


                Console.WriteLine("Gamer gamer till jorden kom");

                if (answer == "1")
                {
                    int damage = friend.Attack();
                    foe.Hurt(damage);
                    Console.WriteLine("You punched for " + damage + "damage.");

                } else if (answer == "2") {
                    Console.WriteLine("onga bonga");
                    //block block

                } else {
                    Console.WriteLine("Please give an answer: 1 or 2");

                }

                int foeMove = generator.Next(0, 2);
                if (foeMove == 1)
                {
                    int damage = foe.Attack();
                    friend.Hurt(damage);
                    Console.WriteLine("You got punched for " + damage + "damage.");

                } else if (foeMove == 2) {
                    Console.WriteLine("onga bonga");
                    //block block

                } else {
                    Console.WriteLine("What?");
                    //What?

                }

            }

            //Check who's dead.
            if (friend.IsAlive() == false)
            {
                Console.WriteLine("You lost");
            }
            else
            {
                Console.WriteLine("You won");
            }

            Console.ReadLine();
        }
    }
}
