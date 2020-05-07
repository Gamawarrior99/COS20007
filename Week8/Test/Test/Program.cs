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
            Golfer Player = new Golfer();
            Putter Putt = new Putter();
            SandWedge sand = new SandWedge();
            /*creation of Objects used */

            /*test if Holding is false*/
            if (Player.Holding() == true)
            {
                Console.WriteLine("Breate and Focus");
                Player.Swing(Putt);
                Player.Swing(sand);
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
                Console.WriteLine("Breate and Focus");
                Player.Swing(Putt);
                Player.Swing(sand);
                Player.Swing(sand); //test reset
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
