using System;
using System.Collections.Generic;
using System.Text;

namespace iteration4
{
    public class Inventory
    {
        private List<Item> _items;

        public Inventory()
        {
            _items = new List<Item>();
        }

        public bool Hasitem(string id)
        {
            return _items.Contains(Fetch(id));
        }

        public void Put(Item itm)
        {
            _items.Add(itm);
        }

        public Item Take(string id)
        {
            Item r = null;
            foreach (Item item in _items)
            {
                if (item.AreYou(id))
                {
                    r = item;
                    _items.Remove(item);
                }
            }
            return r;
        }

        public Item Fetch(string id)
        {
            Item r = null;
            foreach (Item item in _items)
            {
                if (item.AreYou(id))
                {
                    r = item;
                }
            }
            return r;
        }


        public string itemList
        {
            get
            {
                string answer = "The item you currently have is :\n ";
                foreach (Item item in _items)
                {
                    answer += item.ShortDescription + "\n";
                }
                return answer;
            }
        }
    }
}
