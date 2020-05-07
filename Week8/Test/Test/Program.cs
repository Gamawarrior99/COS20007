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
                Console.WriteLine("Choose a \n P) Putter \n S) SandWedge");
                choice = Console.ReadLine();
                Console.WriteLine("Breate and Focus");

                if (choice == "P")
                {
                    Player.Swing(Putt);
                }
                else if (choice == "S")
                {
                    Player.Swing(sand);
                }
                
               
            }
            else
            {
                Console.WriteLine("Where is my Caddy?");
            }

            /* This adds Two types of Clubs to the player */
            Player.PickUp(Putt);
            Player.PickUp(sand);

            /*This Tests if  holding is true */
            if (Player.Holding() == true)
            {
                Console.WriteLine("Choose a \n P) Putter \n S) SandWedge");
                choice = Console.ReadLine();
                Console.WriteLine("Breate and Focus");

                if (choice == "P")
                {
                    Player.Swing(Putt);
                }
                else if (choice == "S")
                {
                    Player.Swing(sand);
                }
            }
            else
            {
                Console.WriteLine("Where is my Caddy?");
            }

            /* keeps informatino on screen to be read */
            Console.ReadLine();
        }
    }
}
