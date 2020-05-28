using System;
using System.Collections.Generic;
using System.Text;
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
            SplashKit.FillRectangle(clr, Pos.X, Pos.Y, Width, Height);
            if (Selected)
            {
                DrawOutline();
            }
        }

        public override bool IsAt(Point2D pt)
        {
            SplashKitSDK.Rectangle rect;
            rect.X = Pos.X;
            rect.Y = Pos.Y;
            rect.Height = Height;
            rect.Width = Width;
            if (SplashKit.PointInRectangle(pt,rect))
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
            SplashKit.DrawRectangle(Color.Black, Pos.X -2, Pos.Y -2, Width +4, Height+4);
        }
    }
}
