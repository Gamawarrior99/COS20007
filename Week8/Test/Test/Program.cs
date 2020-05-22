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

            Console.WriteLine("Choose you Club\n Putter\n SandWedge");
            Console.WriteLine(Player.Holding()); //to test holding

            Player.Swing("Random");


            Player.PickUp("sandwedge");
            Player.Swing("sandwedge");
      

            Console.WriteLine(Player.Holding());

            Player.PickUp("putter");
            Player.Swing("putter");

            Console.WriteLine(Player.Holding());

            Player.PickUp("Random");
            Player.Swing("Random");


            Console.ReadLine();
        }
    }
}
