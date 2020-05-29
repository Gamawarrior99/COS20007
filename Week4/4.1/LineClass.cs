using System;
using System.Collections.Generic;
using System.Text;
using SplashKitSDK;

namespace MultiShape
{
    public class Line : Shape
    {
        private float _endx, _endy;

        public float Endx { get => _endx; set => _endx = value; }
        public float Endy { get => _endy; set => _endy = value; }

        public Line(Color clr, float endX, float endY) : base(clr){}
        public Line() : this(Color.Red, 100, 100){ }
        public override void Draw()
        {
            SplashKit.DrawLine(clr, X, Y, Endx, _endy);
            if (Selected)
            {
                DrawOutline();
            }
        }
        public override bool IsAt(Point2D pt)
        {
            
            if (SplashKit.PointOnLine(pt, SplashKit.LineFrom(X, Y, Endx, _endy)))
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
            SplashKit.FillCircle(Color.Black, X, Y, radius);
            SplashKit.FillCircle(Color.Black, Endx, _endy, radius);
        }
    }
}
