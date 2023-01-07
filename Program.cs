using System.IO;

namespace Retro_Racer
{
    class Program
    {
        /*
            Another thing to note: When you go you have to move in the X direction first??????????????????? then the Y dir does not mess up like it ahs previously


        */
        static void Main(string[] args) // 128x128 = 16384 total entries
        {
            Console.Clear();
            Console.SetWindowSize(151, 51); // Middle 76, 25
            Console.SetBufferSize(151, 51);
            // var middle = (76, 25); // 76 is mid x point, 25 is mid y point

            var trackHandlerC = new trackHandler(trackReference.track1, Console.BufferHeight, Console.BufferWidth);
            var curRacer = new Racer(13200, 13200); // Middle of screen
            var x = 90L;
            var y = 154L;

            trackConverter.convertTrack();

            /*
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.UpArrow:
                            // y--;
                            curRacer.accelerate();
                            break;
                        case ConsoleKey.DownArrow:
                            curRacer.brake();
                            // y++;
                            break;
                        case ConsoleKey.LeftArrow:
                            curRacer.turnLeft();
                            // x++;
                            break;
                        case ConsoleKey.RightArrow:
                            curRacer.turnRight();
                            // x--;
                            break;

                    }
                }

                trackHandlerC.drawTrackSection((int)0, (int)0, (int)x, (int)y);




                curRacer.iterateCar();

                var trackX = curRacer.X / 100;
                var trackY = curRacer.Y / 100;

                Console.SetCursorPosition(0, 0);
                Console.BackgroundColor = ConsoleColor.Black;
                System.Console.Write(" Track X: " + (int)trackX + " Track Y: " + (int)trackY + " Direction: " + curRacer.Direction);

                trackHandlerC.drawTrackSection(0, 0, (int)trackX, (int)trackY);


                // if (trackReference.track1[(int)trackY, (int)trackX] == "Wall" || trackReference.track1[(int)trackY, (int)trackX] == "Grass")
                // {
                //     curRacer.crash();
                // }

            }
            */
        }
    }

}