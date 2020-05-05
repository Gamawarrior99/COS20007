using System;
using System.Collections.Generic;
using System.Text;

namespace Iteration4
{
    public interface IHaveInventory
        {
            Game_Object Locate(string id);
            string Name { get; }
        }
}
