using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration1
{
    class Identifiable_Object
    {
        private List<string> _identifiers;
        

        public List<string> Identifiers
        {
            get
            {
                return _identifiers;
            }
            set
            {
                _identifiers = value;
            }
        }

        public Identifiable_Object(string[] idents)
        {
            _identifiers = new List<string>();
            foreach (string s in idents)
            {
                _identifiers.Add(s.ToLower());
            }
        }

        public bool AreYou(string id)
        {
            foreach (string s in _identifiers)
            {
                if (id.ToLower() == s)
                {
                    return true;
                }
            }
            return false;
        }

        public string FirstId()
        {
            if (_identifiers.Count == 0)
            {
                return "";
            }

            return _identifiers[0];
        }

        public void Add_Identifier(string id)
        {
            _identifiers.Add(id.ToLower());
        }
    }
}
