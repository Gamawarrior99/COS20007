using System;
using System.Collections.Generic;
using System.Text;
using SplashKitSDK;

namespace MultiShape
{
    public class Line : Shape
    {
        private Point2D _endl;
        private SplashKitSDK.Line _lin;

        public Point2D Endl
        {
            get
            {
                return _endl;
            }
            set
            {
                _endl = value;
            }
        }
        public Line(Color clr, float endX, float endY) : base(clr)
        {
            _endl.X = endX;
            _endl.Y = endY;
            

        }
        public Line() : this(Color.Red,  100, 100){}

        public override void Draw()
        {
            SplashKit.DrawLine(clr, Pos.X, Pos.Y, _endl.X, _endl.Y);
            if (Selected)
            {
                DrawOutline();
            }
        }

        public override bool isat(Point2D pt)
        {
            _lin.StartPoint = Pos;
           _lin.EndPoint = _endl;

            if (SplashKit.PointOnLine(pt,_lin))
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
            float radius = 5f;
            SplashKit.FillCircle(Color.Black, Pos.X, Pos.Y, radius);
            SplashKit.FillCircle(Color.Black, _endl.X, _endl.Y, radius);
        }
    }
}
