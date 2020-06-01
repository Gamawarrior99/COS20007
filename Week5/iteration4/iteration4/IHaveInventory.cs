using System;
using System.Collections.Generic;
using System.Text;

namespace iteration4
{
    public interface I_have_inventory
    {
        Game_Object Locate(string id);
        string Name { get; }

    }
}
