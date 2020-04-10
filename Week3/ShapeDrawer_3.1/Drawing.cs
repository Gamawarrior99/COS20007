using System;
using System.Collections.Generic;
using System.Text;
using SplashKitSDK;

namespace ShapeDrawer
{
    class Drawing
    {
        private readonly List<Shape> _shapes;
        private Color _background;

        public Drawing(Color background)
        {
            _shapes = new List<Shape>();
        
        }
        public Drawing() : this(Color.White){ }

        public Color Background
        {
            get
            {
                return _background;
            }
            set
            {
                _background = value;
            }
        }

        public int ShapeCount
        {
            get
            {
                return _shapes.Count;
            }
        }

        public List<Shape> SelectedShapes
        {
            get
            {
                List<Shape> result = new List<Shape>();
                foreach (Shape s in _shapes)
                {
                    if (s.Selected)
                    {
                        result.Add(s);
                    }
                }
                return result;
            }
        }

        public void AddShape(Shape s)
        {
            _shapes.Add(s);
        }

        public void Draw()
        {
            foreach(Shape s in _shapes)
            {
                s.Draw();
            }
        }
        public void SelectShapesAt(Point2D pt)
        {
            foreach (Shape s in _shapes)
            {
                if (s.IsAt(pt))
                {
                    s.Selected = true;
                }
            }

            
        }

        public void RemoveShape(Shape s)
        {
            _shapes.Remove(s);
        }


    }
}
