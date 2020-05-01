using System;
using SplashKitSDK;

namespace MultiShape
{
    public class Program
    {
        private enum ShapeKind
        {
            Rectangle, Circle, Line
        }
        public static void Main()
        {
            new Window("Shape Drawer", 800, 600);
            Drawing MyDraw = new Drawing { Background = Color.White };
            SplashKit.ClearScreen(MyDraw.Background);
            ShapeKind Kindtoadd = ShapeKind.Circle;
            Random rnd = new Random();
            Point2D lin;
            int x_axis;
            int y_axis;

            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen(MyDraw.Background);

                if (SplashKit.KeyTyped(KeyCode.RKey))
                {
                    Kindtoadd = ShapeKind.Rectangle;
                }
                else if (SplashKit.KeyTyped(KeyCode.CKey))
                {
                    Kindtoadd = ShapeKind.Circle;
                }
                else if (SplashKit.KeyTyped(KeyCode.LKey))
                {
                    Kindtoadd = ShapeKind.Line;
                }

                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    Shape newShape;
                    if (Kindtoadd == ShapeKind.Circle)
                    {
                        Circle newCircle = new Circle();
                        newCircle.Pos = SplashKit.MousePosition();
                        newShape = newCircle;
                    }
                    else if (Kindtoadd == ShapeKind.Rectangle)
                    {
                        Rectangle newRect = new Rectangle();
                        newRect.Pos = SplashKit.MousePosition();
                        newShape = newRect;
                    }
                    else
                    {
                        Line newLine = new Line();
                        newLine.Pos = SplashKit.MousePosition();
                        x_axis = rnd.Next(-400, 400);
                        y_axis = rnd.Next(-300, 300);
                        lin.X = SplashKit.MouseX() + x_axis;
                        lin.Y = SplashKit.MouseY() + y_axis;
                        newLine.Endl = lin;
                        newShape = newLine;
                    }
                    MyDraw.AddShape(newShape);
                }

                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    MyDraw.Background = SplashKit.RandomRGBColor(255);
                }

                if (SplashKit.MouseClicked(MouseButton.RightButton))
                {
                    MyDraw.SelectShapeAt();
                }
                if (SplashKit.KeyTyped(KeyCode.DeleteKey) || SplashKit.KeyTyped(KeyCode.BackspaceKey))
                {
                    foreach (Shape s in MyDraw.SelectedShape)
                    {
                        MyDraw.RemoveShape(s);
                    }
                }

                MyDraw.Draw();
                SplashKit.RefreshScreen(60);
            } while (!SplashKit.WindowCloseRequested("Shape Drawer"));

        }
    }
}

