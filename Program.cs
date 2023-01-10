using System.IO;
using System.Threading;

namespace Retro_Racer
{
    class Program
    {
        /*
            Another thing to note: When you go you have to move in the X direction first??????????????????? then the Y dir does not mess up like it ahs previously


        */
        public static void Main(string[] args) // 128x128 = 16384 total entries
        {

            Console.Clear();
            Console.SetWindowSize(151, 51);
            Console.SetBufferSize(151, 51);  // 76 is mid x point, 25 is mid y point

            var trackHandlerC = new trackHandler(trackReference.track1, Console.BufferHeight, Console.BufferWidth);
            var curRacer = new Racer(13200, 13200); // Middle of screen

            // Console.WriteLine("REMEMBER, to exit press ctrl + c keys at the same time!!!");
            // Thread.Sleep(1000);
            // titleRefrence.showCreds();
            // Thread.Sleep(1000);
            // titleRefrence.showGameTitle();
            // Thread.Sleep(1000);

            var selection = Title();

            switch (selection)
            {
                case 1:
                    startGame(trackHandlerC, curRacer);
                    break;
                case 2:
                    trackConverter.convertTrack();
                    break;
            }

            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Don't know why your here? GLHF {0}", selection);

        }



        public static int Title()
        {
            var title = new titleRefrence();
            var menuCounter = 0;
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.UpArrow:
                            if (menuCounter > 1) menuCounter--;
                            else menuCounter++;
                            break;
                        case ConsoleKey.DownArrow:
                            if (menuCounter < 2) menuCounter++;
                            else menuCounter--;
                            break;
                        case ConsoleKey.Enter:
                            switch (menuCounter)
                            {
                                case 1:
                                    // Start Game
                                    return 1;

                                case 2:
                                    // Convert Game
                                    // Environment.Exit(0);
                                    return 2;
                            }
                            break;

                    }
                }
                title.showTitle(menuCounter);
            }
        }

        public static void startGame(trackHandler trackHandlerC, Racer curRacer)
        {
            var x = 90L;
            var y = 154L;
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

                curRacer.iterateCar();

                var trackX = curRacer.X / 100;
                var trackY = curRacer.Y / 100;

                Console.SetCursorPosition(0, 0);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Write(" Track X: " + (int)trackX + " Track Y: " + (int)trackY + " Direction: " + curRacer.Direction);

                trackHandlerC.drawTrackSection(0, 0, (int)trackX, (int)trackY);


            }

        }
    }

}