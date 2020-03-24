using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration1
{
    class Identifiable_Object
    {
        private List<string> _identifiers = new List<string>();
        private int _i = 0;

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
            Identifiers = new List<string>(idents);
        }

        public bool AreYou(string id)
        {
            foreach (string s in Identifiers)
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
            if (Identifiers.Count == 0)
            {
                return "";
            }

            return Identifiers[0].ToLower();
        }

        public void Add_Identifier(string id)
        {
            _identifiers.Add(id.ToLower());
        }
    }
}
