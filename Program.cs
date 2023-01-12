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
                    startGame();
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

        public static void startGame()
        {

            var trackHandlerC = new trackHandler(trackReference.Track1, Console.BufferHeight, Console.BufferWidth);
            var curRacer = new Racer(35000, 25000); // Middle of screen

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
                Console.Write(" Track X: " + (int)trackX + " Track Y: " + (int)trackY + " Direction: " + curRacer.Direction + " Speed: " + curRacer.Speed);

                trackHandlerC.drawTrackSection(0, 0, (int)trackX, (int)trackY);

                // curRacer.checkCrash(trackHandlerC);
                curRacer.draw();


            }

        }
    }

}