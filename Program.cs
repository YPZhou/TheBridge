using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SFML.Window;
using SFML.Graphics;

namespace TheBridge
{
    class Program
    {
        static void Main(string[] args)
        {
            RenderWindow window = new RenderWindow(new VideoMode(800, 600), "The Bridge", Styles.Fullscreen);

            while (window.IsOpen())
            {
                window.DispatchEvents();

                if (Keyboard.IsKeyPressed(Keyboard.Key.Escape))
                {
                    window.Close();
                }

                window.Clear(Color.Black);
                //Update();
                //Render(window);
                window.Display();
            }
        }
    }
}
