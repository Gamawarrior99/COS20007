using System;
using System.Collections.Generic;
using System.Text;

namespace iteration4
{
    class Look_Command : Command
    {
        public Look_Command(string[] ids) : base(new string[] { "look" }){}
        private string Look_At_In(string tId, I_have_inventory container)
        {
            Game_Object obj;
            obj= container.Locate(tId);

            if ( obj != null)
            {
                return obj.FullDescription;
            }
            else
            {
                return "I cannot find " + tId + " in the " + container;

            }
        }

        private I_have_inventory Fetch_Container(Player p, string containerid)
        {
            return p.Locate(containerid) as I_have_inventory;
        }

        public override string Exe(Player p, string[] text)
        {
            if (text.Length != 3 && text.Length != 5)
            {
                return "I don't know how to look like that";
            }
            if (text[0] != "look")
            {
                return "Error in look input";
            }

            if (text[1] != "at")
            {
                return "What do you want to look at?";
            }
            if (text.Length == 5 && text[3] != "in")
            {
                return "What do you want to look in?";
            }

            if (text.Length == 3)
            {
                return Look_At_In(text[2], p);
            }

            if (text.Length == 5)
            {
                if (Fetch_Container(p, text[4]) == null)
                {
                    return "Cannot find the " + text[4];
                }
                string var = Look_At_In(text[2], Fetch_Container(p, text[4]));

                if (var == null)
                {
                    return "Cannot find the " + text[2];
                }
                else
                {

                    return var;
                }
            }
            return "Error";
        }
    }
}
