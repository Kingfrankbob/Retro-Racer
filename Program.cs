using System.IO;
using System.Threading;

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
                                                    // var x = 90L;
                                                    // var y = 154L;
            trackHandler.showCred();
            Thread.Sleep(1000);
            trackHandler.showTitle();
            Thread.Sleep(1000);

            var selection = Title();

            System.Console.WriteLine("Hello World! {0}", selection);

            // var title = new titleRefrence();
            // var menuShow = true;
            // var menuCounter = 0;

            // trackHandlerC.showCred();  // WORK ON COLOR ARRAYS
            // trackHandlerC.showTitle();
            // for (int i = 0; i < 151; i++) System.Console.Write("a");

            // trackConverter.convertTrack();





            // while (true)
            // {
            //     if (Console.KeyAvailable)
            //     {
            //         switch (Console.ReadKey().Key)
            //         {
            //             case ConsoleKey.UpArrow:
            //                 if (menuShow && menuCounter > 1) menuCounter--;
            //                 else menuCounter++;
            //                 // y--;
            //                 // curRacer.accelerate();
            //                 break;
            //             case ConsoleKey.DownArrow:
            //                 if (menuShow && menuCounter < 2) menuCounter++;
            //                 else menuCounter--;
            //                 // curRacer.brake();
            //                 // y++;
            //                 break;
            //             case ConsoleKey.LeftArrow:
            //                 // curRacer.turnLeft();
            //                 // x++;
            //                 break;
            //             case ConsoleKey.RightArrow:
            //                 // curRacer.turnRight();
            //                 // x--;
            //                 break;
            //             case ConsoleKey.Enter:
            //                 if (menuShow) menuShow = false;
            //                 switch (menuCounter)
            //                 {
            //                     case 1:
            //                         // Start Game
            //                         break;
            //                     case 2:
            //                         // Convert Game
            //                         // Environment.Exit(0);
            //                         trackConverter.convertTrack();
            //                         break;
            //                 }
            //                 break;

            //         }
            //     }

            //     if (menuShow) title.showTitle(menuCounter);

            // trackHandlerC.drawTrackSection((int)0, (int)0, (int)x, (int)y);




            // curRacer.iterateCar();

            // var trackX = curRacer.X / 100;
            // var trackY = curRacer.Y / 100;

            // Console.SetCursorPosition(0, 0);
            // Console.BackgroundColor = ConsoleColor.Black;
            // System.Console.Write(" Track X: " + (int)trackX + " Track Y: " + (int)trackY + " Direction: " + curRacer.Direction);

            // trackHandlerC.drawTrackSection(0, 0, (int)trackX, (int)trackY);


            // if (trackReference.track1[(int)trackY, (int)trackX] == "Wall" || trackReference.track1[(int)trackY, (int)trackX] == "Grass")
            // {
            //     curRacer.crash();
            // }

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
                                    trackConverter.convertTrack();
                                    break;
                            }
                            break;

                    }
                }
                title.showTitle(menuCounter);
            }
        }

        public static void startGame(trackHandler trackHandlerC, Racer curRacer)
        {

        }

    }
}