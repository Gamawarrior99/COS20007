using System;
using System.Collections.Generic;
using System.Text;
using SplashKitSDK;

namespace MultiShape
{
    public class Circle : Shape
    {
        private int _radius;
        private SplashKitSDK.Circle cir;
         
        

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
        public Circle() : this(Color.Blue, 50){}


        public override void Draw()
        {
            SplashKit.FillCircle(clr, Pos.X, Pos.Y, Radius);
            if (Selected)
            {
                DrawOutline();
            }
        }

        public override bool isat(Point2D pt)
        {
            cir.Radius = Radius;
            cir.Center = Pos;

            if  (SplashKit.PointInCircle(pt, cir))
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
            SplashKit.DrawCircle(Color.Black, Pos.X , Pos.Y, Radius+2);
        }
    }
}
