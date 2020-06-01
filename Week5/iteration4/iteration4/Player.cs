using System;
using System.Collections.Generic;
using System.Text;

namespace iteration4
{
    class Player : Game_Object, I_have_inventory
    {
        private Inventory _inventory;
        public Inventory inventory
        {
            get
            {
                return _inventory;
            }
        }

        public Player(string name, string desc) : base(new string[] { "me", "inventory" }, name, desc)
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
                return inventory.Fetch(id);
            }
        }

        public override string FullDescription
        {
            get
            {
                return "You are " + Name + ". " + Desc + ".";
            }
        }
    }
}
