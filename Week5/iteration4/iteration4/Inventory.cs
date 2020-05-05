using System;
using System.Collections.Generic;
using System.Text;

namespace Iteration4
{
    public class Inventory
    {
        private List<Item> _items = new List<Item>();

        public Inventory()
        {
        }

        public Item Fetch(string id)
        {
            Item Result = null;
            foreach (Item I in _items)
            {
                if (I.AreYou(id))
                {
                    Result = I;
                }
            }
            return Result;
        }

        public bool HasItem(string id)
        {
            return _items.Contains(Fetch(id));

        }

        public void Put(Item itm)
        {
            _items.Add(itm);
        }

        public Item Take(string id)
        {
            Item Result = null;
            foreach (Item I in _items)
            {
                if (I.AreYou(id))
                {
                    Result = I;
                }
            }
            _items.Remove(Result);
            return Result;
        }
        public string ItemList
        {
            get
            {
                string i = "";
                foreach (Item I in _items)
                {
                    i += I.Name + I.ShortDescription + "\n";

                }
                return i;
            }
        }

    }
}
