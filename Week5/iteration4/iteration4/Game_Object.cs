using System;
using System.Collections.Generic;
using System.Text;

namespace iteration4
{
    public abstract class Game_Object : Identifiable_object
    {
        private string _description;
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public string Desc
        {
            get
            {
                return _description;
            }
        }

        public string ShortDescription
        {
            get
            {
                return _name + " " + _description;
            }
        }

        public virtual string FullDescription
        {
            get
            {
                return _description;
            }
        }

        public Game_Object(string[] ids, string name, string desc) : base(ids)
        {
            _name = name;
            _description = desc;
        }
    }
}
