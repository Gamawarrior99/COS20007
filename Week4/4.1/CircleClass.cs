using System;
using System.Collections.Generic;
using System.Text;
using SplashKitSDK;

namespace MultiShape
{
    public class Circle : Shape
    {
        private int _radius;

        public int Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = value;
            }
        }
        public Circle(Color clr, int radius) : base(clr)
        {
            _radius = radius;
        }
        public Circle() : this(Color.Blue, 50)
        {
        }


        public override void Draw()
        {
            SplashKit.FillCircle(clr, X, Y, Radius);
            if (Selected)
            {
                DrawOutline();
            }
        }

        public override bool IsAt(Point2D pt)
        {
            if  (SplashKit.PointInCircle(pt, SplashKit.CircleAt(X,Y, Radius)))
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
            SplashKit.DrawCircle(Color.Black, X , Y, Radius+2);
        }
    }
}
