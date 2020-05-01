using System;
using System.Collections.Generic;
using System.Text;
using SplashKitSDK;

namespace MultiShape
{
    public abstract class Shape
    {
        private  Point2D _Pos;
        private Color _color;
        private bool _selected;

        public Color clr
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }

        public Point2D Pos
        {
            get
            {
                return _Pos;
            }
            set
            {
                _Pos = value;
            }
        }

        public bool Selected
        {
            get
            {
                return _selected;
            }
            set
            {
                _selected = value;
            }
        }

        public Shape(Color colour)
        {
            _color = colour;
        }

        public Shape() : this(Color.White)
        {
        }

        public abstract void Draw();

        public abstract bool isat(Point2D pt);

        public abstract void DrawOutline();

    }
}
