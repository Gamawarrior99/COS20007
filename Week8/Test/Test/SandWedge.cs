using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class SandWedge : GolfClub
    {
        private int _count;

        public SandWedge() 
        {
            _count = 5;
        }

        public override void Swing()
        {
            while (_count > 0)
            {
                Console.WriteLine("I am in my happy place");
                _count -= 1;
            }
            if (_count == 0)
            {
                Console.WriteLine("Hand me My hockey Stick");
                this.Throw();
            }
        }

        public void Throw()
        {
            _count = 5;
        }

    }
}
