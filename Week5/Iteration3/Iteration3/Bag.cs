using System;
using System.Collections.Generic;
using System.Text;

namespace Iteration3
{
    class Bag:Item
    {
        Inventory _inventory = new Inventory();

        public Inventory Inventory
        {
            get
            {
                return _inventory;
            }
            set
            {
                _inventory = value;
            }
        }

        public Bag(string[] id, string name, string desc):base(new string[] { "Bag", "bag", "Bags", "bags", "BAG", "BAG" }, "Bags", "Bag")
        { 
           
        }

        public override string FullDescription
        {
            get
            {
                return "You Are Carraying \n" + _inventory.ItemList;
            }
        }
        public Game_Object Locate(string id)
        {
            if (AreYou(id))
            {
                return this;
            }
            else
            {
                return _inventory.Fetch(id);
            }
        }
    }
}
