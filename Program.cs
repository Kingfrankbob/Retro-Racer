using System.IO;
using System.Threading;
using System.Runtime.InteropServices;

namespace Retro_Racer
{
    class Program
    {
        /*
        */
        public static void Main(string[] args) // 128x128 = 16384 total entries
        {

            Console.Clear();
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                Console.SetWindowSize(151, 51);
                Console.SetBufferSize(151, 51);  // 76 is mid x point, 25 is mid y point
            }

            System.Console.WriteLine(RuntimeInformation.OSDescription);


            // Console.WriteLine("REMEMBER, to exit press ctrl + c keys at the same time!!!");
            // Console.WriteLine("CONVERSION DOES NOT WORK ON LINUX ATM!!!");
            // Thread.Sleep(1000);
            // titleRefrence.showCreds();
            // Thread.Sleep(750);
            // titleRefrence.showGameTitle();
            // Thread.Sleep(750);

            var selection = Title();

            // var selection = 69;

            // Font.print(0, 0, "hello");

            switch (selection)
            {
                case 1:
                    setGame();
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

        public static void setGame()
        {
            var handSet = new settingsHandler();

            handSet.handleSettings();

            startGame(handSet.TrackSelection, handSet.Accel, handSet.MaxSpeed);
        }

        public static void startGame(string Track, double accel, int maxSpeed)
        {

            var trackHandlerC = new trackHandler(trackReference.Track1, Console.BufferHeight, Console.BufferWidth);
            var curRacer = new Racer(trackHandlerC.StartX * 100, trackHandlerC.StartY * 100, accel, maxSpeed); // Middle of screen

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