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

            Player.PickUp(Putt);
            Player.PickUp(sand);

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
            Console.ReadLine();
        }
    }
}
