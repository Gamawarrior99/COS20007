using System;
using System.Collections.Generic;
using System.Text;

namespace Iteration4
{
	public abstract class Command:indentifiable
    {
            public Command(String[] ids):base(ids)
            {
            }
            abstract public string Execute(Player p, string[] text);
    }
}
