using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualBasic;
using SplashKitSDK;

namespace MultiShape
{
    class Rectangle : Shape
    {
        private int _width, _height;
        
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }

        public Rectangle(Color clr,  int width, int height) : base(clr)
        {  
            Width = width;
            Height = height;
        }
        public Rectangle() : this(Color.Green, 150, 100){}
        public override void Draw()
        {
            SplashKit.FillRectangle(clr, X, Y, Width, Height);
            if (Selected)
            {
                DrawOutline();
            }
        }

        public override bool IsAt(Point2D pt)
        {
  
            if (SplashKit.PointInRectangle(pt, SplashKit.RectangleFrom(X, Y, Width, Height)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void DrawOutline()
        {
            SplashKit.DrawRectangle(Color.Black, X -2, Y -2, Width +4, Height+4);
        }
    }
}
