using System;
using System.Collections.Generic;
using System.Text;

namespace iteration4
{
    abstract class Command : Identifiable_object
    {
        public Command(string[] ids) : base(ids) { }
        abstract public string Exe(Player p, string[] text);
    }
}
