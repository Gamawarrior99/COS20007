using System;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class Program
    {
        public static void Main()
        {
            Drawing myDraw = new Drawing();
            new Window("Shape Drawer", 800, 600);
            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();
                myDraw.Draw();


                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    Shape myshape = new Shape();
                    myshape.X = SplashKit.MouseX();
                    myshape.Y = SplashKit.MouseY();
                    myshape.color = SplashKit.RandomColor();
                    myDraw.AddShape(myshape);
                }

                if (SplashKit.KeyDown(KeyCode.SpaceKey))
                {
                    myDraw.Background = SplashKit.RandomColor();
                }

                if (SplashKit.MouseClicked(MouseButton.RightButton))
                {
                    myDraw.SelectShapesAt(SplashKit.MousePosition());
                }

                if (SplashKit.KeyDown(KeyCode.DeleteKey) || SplashKit.KeyDown(KeyCode.BackspaceKey))
                {
                    foreach (Shape s in myDraw.SelectedShapes)
                    {
                        myDraw.RemoveShape(s);
                    }
                }
                SplashKit.RefreshScreen();
            } while (!SplashKit.WindowCloseRequested("Shape Drawer"));

        }
    }
}

