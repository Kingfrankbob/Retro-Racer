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

        public void handleSettings()
        {
            int choice = 0;
            if (Console.KeyAvailable)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow:
                        if (choice > 0) choice--;
                        else choice++;
                        break;
                    case ConsoleKey.DownArrow:
                        if (choice < 1) choice++;
                        else choice--;
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
        private string[,] previousShow = new string[51, 151];

        public void showSelect(int choice)
        {
            var currentTrack = new string[,] { };
            switch (choice)
            {
                case 0: currentTrack = settingsRefrence.TrackSelect; break;
                case 1: currentTrack = settingsRefrence.SpeedSelect; break;
                case 2: { currentTrack = settingsRefrence.Start; Font.print(100, 30, "Start"); } break;
            }

            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 151; j++)
                {
                    if (previousShow[i, j] != currentTrack[i, j])
                    {
                        Console.SetCursorPosition(j, i);
                        Console.BackgroundColor = ConsoleColor.DarkBlue;
                        Console.Write(' ');
                        Console.SetCursorPosition(j, i);
                        // Console.Write(currentTrack[i, j]);
                        switch (currentTrack[i, j])
                        {
                            case "Track":
                                Console.BackgroundColor = ConsoleColor.DarkYellow;
                                break;
                            case "Grass":
                                Console.BackgroundColor = ConsoleColor.Green;
                                break;
                            case "Wall":
                                Console.BackgroundColor = ConsoleColor.Black;
                                break;
                            case "Unknown":
                                Console.BackgroundColor = ConsoleColor.DarkCyan;
                                break;
                        }
                        Console.Write(' ');
                        previousShow[i, j] = currentTrack[i, j];

                    }
                }
                Console.SetCursorPosition(0, 0);
            }
            Console.SetCursorPosition(0, 0);
        }

        public void handleTracks()
        {
            
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