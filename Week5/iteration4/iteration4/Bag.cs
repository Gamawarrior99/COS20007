using System;
using System.Collections.Generic;
using System.Text;

namespace iteration4
{
    public class Bag : Item, I_have_inventory
    {
        private Inventory _inventory;

        public Inventory Inventory
        {
            get
            {
                return _inventory;
            }
        }

        public Bag(string[] idents, string name, string desc) : base(new string[] { "Bag", "Your trusty Bag" }, "Bag", "Your trusty bag that you take everywhere")
        {
            _inventory = new Inventory();
        }

        public Game_Object Locate(string id)
        {
            if (AreYou(id))
            {
                return this;
            }
            else
            {
                return Inventory.Fetch(id);
            }
        }

        public override string FullDescription
        {
            get
            {
                return "Your trusty bag that you take everywhere\n " + Inventory.itemList;
            }
        }
    }
}
