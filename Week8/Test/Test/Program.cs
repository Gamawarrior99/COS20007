using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        public static void Main()
        {
            /*creation of Objects used */
            Golfer Player = new Golfer();
            Putter Putt = new Putter();
            SandWedge sand = new SandWedge();
            string choice = "P";

            /*test if Holding is false*/
            if (Player.Holding() == true)
            {
                Console.WriteLine("Choose From the Follwowing \n P) Putter \n S) SandWedge");
                Console.Write("Choice");
                choice = Console.ReadLine();
                Console.WriteLine("Breathe and Focus");

                if (choice.ToLower() == "p")
                {
                    Player.Swing(Putt);
                }
                else if (choice.ToLower() == "s")
                {
                    Player.Swing(sand);
                }
            }
            else
            {
                Console.WriteLine("Where is my Caddy?\n");
            }

            /* This adds Two types of Clubs to the player */
            Player.PickUp(Putt);
            Player.PickUp(sand);

            while (choice.ToLower() != "n") // loop to test differnt swing types and if it resets
            {
                Console.WriteLine("Choose From the Follwowing \n P) Putter \n S) SandWedge");
                Console.Write("Choice: ");
                choice = Console.ReadLine();

                if (Player.Holding() == true)
                {
                    Console.WriteLine("Breathe and Focus");

                    if (choice.ToLower() == "p")
                    {
                        Player.Swing(Putt);
                    }
                    else if (choice.ToLower() == "s")
                    {
                        Player.Swing(sand);
                    }
                }
                else
                {
                    Console.WriteLine("Where is my Caddy? \n");
                }
            }
        }
    }
}
