using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using SplashKitSDK;

namespace MultiShape
{
    public abstract class Shape
    {
        private float _x, _y;
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
        public float X
        {

            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }

        public float Y
        {

            get
            {
                return _y;
            }
            set
            {
                _y = value;
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

        public abstract bool IsAt(Point2D pt);

        public abstract void DrawOutline();

    }
}
