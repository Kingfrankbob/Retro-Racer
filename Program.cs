using System.IO;

namespace Retro_Racer
{
    class Program
    {
        static void Main(string[] args) // 128x128 = 16384 total entries
        {
            Console.Clear();
            Console.SetWindowSize(151, 51); // Middle 76, 25
            Console.SetBufferSize(151, 51);
            var middle = (76, 25); // 76 is mid x point, 25 is mid y point

            var trackHandlerC = new trackHandler(trackReference.track1, Console.BufferHeight, Console.BufferWidth, middle.Item1, middle.Item2);
            var curRacer = new Racer(76, 25);
            var x = 90L;
            var y = 154L;
            var trck = trackReference.track1;

            // trackHandlerC.drawTrackSection(middle.Item1 - 76, middle.Item2 - 25);

            // var previousCounter = 0;
            // var spriteCounter = 0;

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.UpArrow:
                            // curRacer.accelerate();
                            if (y < 188) y++;
                            break;
                        case ConsoleKey.DownArrow:
                            // curRacer.brake();
                            if (y > 75) y--;
                            break;
                        case ConsoleKey.LeftArrow:
                            // curRacer.turnLeft();
                            if (x > 75) x--;
                            break;
                        case ConsoleKey.RightArrow:
                            // curRacer.turnRight();
                            if (x < 188) x++;
                            break;

                    }
                }

                trackHandlerC.drawTrackSection((int)0, (int)0, (int)x, (int)y);


                // System.Console.Write("X: " + curRacer.X + " Y: " + curRacer.Y + " D: " + curRacer.Direction + " S: " + curRacer.Speed + "         ");

                // var trackX = curRacer.X / 10;
                // var trackY = curRacer.Y / 10;

                // trackHandlerC.drawTrackSection(0, 0, (int)trackX, (int)trackY);
                // curRacer.iterateCar();


                // if (trackReference.track1[(int)trackY, (int)trackX] == "Wall" || trackReference.track1[(int)trackY, (int)trackX] == "Grass")
                // {
                //     curRacer.crash();
                // }

            }
        }
    }

}