using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Retro_Racer
{
    public class settingsHandler
    {
        private int _speed;
        private string _trackSelection = "";

        private (bool, bool, bool) _PhighLight = (false, false, false);

        private string[,] previousShow = new string[51, 151];


        public void handleSettings()
        {
            int choice = 0;
            while (true)
            {

                if (Console.KeyAvailable)
                {
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.UpArrow:
                            if (choice > 0) choice--;
                            else choice = 2;
                            break;
                        case ConsoleKey.DownArrow:
                            if (choice < 2) choice++;
                            else choice = 0;
                            break;
                        case ConsoleKey.Enter:
                            switch (choice)
                            {
                                case 0:
                                    handleTracks();
                                    break;

                                case 1:
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Clear();
                                    Console.WriteLine(@"Enter a speed at which you would like to play at (number only):
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\
1. Slow
2. Medium
3. Fast
4. Insane
5. Ludicrous
6. Insanely Ludicrous
");
                                    var yes = Console.ReadLine();
                                    if (Convert.ToInt32(yes) == 6) _speed = 1000;
                                    else _speed = Convert.ToInt32(yes) * 10 + 20;
                                    Console.WriteLine("You have selected a speed of {0}", _speed);
                                    handleSettings();
                                    break;

                                case 2:
                                    Program.startGame(_trackSelection, Accel, MaxSpeed);
                                    break;
                            }
                            break;

                    }
                }
                showSelect(choice);
            }
        }

        public void showSelect(int choice)
        {
            var highLight = (false, false, false);
            switch (choice)
            {
                case 0: { highLight.Item1 = true; highLight.Item2 = false; highLight.Item3 = false; } break;
                case 1: { highLight.Item1 = false; highLight.Item2 = true; highLight.Item3 = false; } break;
                case 2: { highLight.Item1 = false; highLight.Item2 = false; highLight.Item3 = true; } break;
            }

            if (highLight != _PhighLight)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Clear();
                if (highLight.Item1) { Font.printHighlight(2, 2, "Track Selection"); Font.print(2, 16, "Speed Selection"); Font.print(2, 30, "Start Game"); }
                else if (highLight.Item2) { Font.print(2, 2, "Track Selection"); Font.printHighlight(2, 16, "Speed Selection"); Font.print(2, 30, "Start Game"); }
                else if (highLight.Item3) { Font.print(2, 2, "Track Selection"); Font.print(2, 16, "Speed Selection"); Font.printHighlight(2, 30, "Start Game"); }
                else { System.Console.WriteLine("Error, should not make it here.../nPlease stop messing with the code :rofl: :lmao:\nError -> SystemInvalidBoolOperator\nCannot recognize \"Broken\" as a value."); }
                // return highLight;
            }
            _PhighLight = highLight;
        }

        public void handleTracks()
        {
            var trackReference = new trackReference();
            var fields = trackReference.GetType().GetFields().Select(f => f.Name).ToList();
            var currentSelection = 0;

            while (true)
            {
                for (int i = 0; i < fields.Count; i++)
                {
                    var name = fields[i];
                    if (!name.Contains("Start") && currentSelection != i) { Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.White; System.Console.WriteLine(name); }
                    else if (!name.Contains("Start") && currentSelection == i) { Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.Black; System.Console.WriteLine(name); }
                }
                if (Console.KeyAvailable)
                {
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.UpArrow:
                            if (currentSelection > 0) currentSelection--;
                            else currentSelection = fields.Count - 1;
                            break;
                        case ConsoleKey.DownArrow:
                            if (currentSelection < fields.Count - 1) currentSelection++;
                            else currentSelection = 0;
                            break;
                        case ConsoleKey.Enter:
                            _trackSelection = fields[currentSelection];
                            handleSettings();
                            break;
                    }
                }


            }
        }

        public string TrackSelection
        {
            get { return _trackSelection; }
        }
        public int MaxSpeed
        {
            get { return _speed; }
        }
        public double Accel
        {
            get { return _speed / 10; }
        }
    }
}