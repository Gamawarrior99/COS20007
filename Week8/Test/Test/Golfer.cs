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
        private GolfClub _Putt = new Putter();
        private GolfClub _Sand = new SandWedge();

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
            if (Club == _Putt.Name)
            {
                _club.Add(_Putt);
            }
            else if (Club == _Sand.Name)
            {
                _club.Add(_Sand);
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
               
            }
        }
    }
}
