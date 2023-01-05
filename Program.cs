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
            var middle = (76, 25);

            var trackHandlerC = new trackHandler(trackReference.track1, Console.BufferHeight, Console.BufferWidth);
            var curRacer = new Racer(76, 25);

            // trackHandlerC.drawTrackSection(middle.Item1 - 76, middle.Item2 - 25);

            // var counter = 1;
            // var previousCounter = 0;
            // var spriteCounter = 0;

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.UpArrow:
                            curRacer.accelerate();
                            break;
                        case ConsoleKey.DownArrow:
                            curRacer.brake();
                            break;
                        case ConsoleKey.LeftArrow:
                            curRacer.turnLeft();
                            break;
                        case ConsoleKey.RightArrow:
                            curRacer.turnRight();
                            break;

                    }
                }

                Console.SetCursorPosition(0, 0);
                Console.BackgroundColor = ConsoleColor.Black;
                System.Console.Write("X: " + curRacer.X + " Y: " + curRacer.Y + " D: " + curRacer.Direction + " S: " + curRacer.Speed + "         ");

                var trackX = curRacer.X / 10;
                var trackY = curRacer.Y / 10;

                trackHandlerC.drawTrackSection(0, 0, (int)trackX, (int)trackY);
                curRacer.iterateCar();


                if (trackReference.track1[(int)trackY, (int)trackX] == "Wall" || trackReference.track1[(int)trackY, (int)trackX] == "Grass")
                {
                    curRacer.crash();
                }

            }
        }
    }

}