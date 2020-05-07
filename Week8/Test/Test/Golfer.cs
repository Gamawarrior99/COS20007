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

        public void PickUp(GolfClub Club)
        {
            _club.Add(Club);

        }

        public void Swing(GolfClub Club)
        {
            foreach (GolfClub C in _club)
            {
                if (C == Club)
                {
                    C.Swing();
                }
            }
        }
    }
}
