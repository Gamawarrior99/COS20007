﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Putter : GolfClub
    {
         
        public Putter()
        {
            Name = "putter";
        }
        public override void Swing()
        {
            Console.WriteLine("Putt Putt Puttn\n");
        }
    }
}
