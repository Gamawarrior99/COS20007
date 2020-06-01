using System.Collections.Generic;

namespace iteration4
{
    public class Identifiable_object
    {
        private List<string> _identifiers;

        public Identifiable_object(string[] idents)
        {
            Identifiers = new List<string>(idents);
        }

        public bool AreYou(string id)
        {
            foreach (string idents in _identifiers)
            {
                if (id.ToLower() == idents.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

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


        public string Firstid()
        {
            if (_identifiers.Count == 0)
            {
                return "";
            }

            return _identifiers[0].ToLower();

        }

        public void AddIdentifier(string id)
        {
            Identifiers.Add(id.ToLower());
        }

    }
}
