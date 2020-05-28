using System;
using System.Collections.Generic;
using System.Text;
using SplashKitSDK;

namespace MultiShape
{
    class Drawing
    {
        private readonly List<Shape> _shapes;
        private Color _background;

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

        public Drawing(Color background)
        {
            _shapes = new List<Shape>();
            _background = background;
        }

        public Drawing() : this(Color.White){}

        public int ShapeCount
        {
            get
            {
                return _shapes.Count;
            }
        }

        public void AddShape(Shape s)
        {
            _shapes.Add(s);
        }

        public void Draw()
        {
            SplashKit.ClearScreen(_background);
            foreach (Shape s in _shapes)
            {
                s.Draw();
            }
        }

        public void SelectShapeAt()
        {
            foreach (Shape s in _shapes)
            {
                if (s.IsAt(SplashKit.MousePosition()))
                {
                    s.Selected = true;
                }
                else
                {
                    s.Selected = false;
                }
            }
        }

        public List<Shape> SelectedShape
        {
            get
            {
                List<Shape> SelectedShapes = new List<Shape>();
                foreach (Shape s in _shapes)
                {
                    if (s.Selected)
                    {
                        SelectedShapes.Add(s);
                    }
                }

                return SelectedShapes;
            }
        }

        public void RemoveShape(Shape s)
        {
            _shapes.Remove(s);
        }
    }
}
