using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Golfer
    {
        private List<GolfClub> _club;
        GolfClub Putt = new Putter();
        GolfClub sand = new SandWedge();

        public Golfer()
        {
            _club = new List<GolfClub>();
        }

        public bool Holding()
        {
            if (_club.Count() != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PickUp(string Club)
        {
            if (Club == Putt.Name)
            {
                _club.Add(Putt);
            }
            else if (Club == sand.Name)
            {
                _club.Add(sand);
            }
            else
            {
                Console.WriteLine("Club Doesn't exist");
            }

        }

        public void Swing(string  Club)
        {
            foreach (GolfClub c in _club)
            {
                if (Club == c.Name)
                {
                    c.Swing();
                }
                else
                {
                    Console.WriteLine("Club Doesn't exist");
                }
            }
        }
    }
}
