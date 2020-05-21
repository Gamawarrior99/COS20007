using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
   public abstract class GolfClub
    {
        private string _name;
        public GolfClub()
        {
            _name = "name";
        }

        public string Name 
        { 
            get => _name; 
            set => _name = value; 
        }

        public abstract void Swing();
    }
}
