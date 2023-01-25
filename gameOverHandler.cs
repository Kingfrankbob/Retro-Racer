using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Retro_Racer
{
    public class gameOverHandler
    {
        public static void GameOver()
        {
            for (int f = 0; f < 1; f++)
            {
                for (int i = 0; i < 50; i++)
                {
                    for (int j = 0; j < 151; j++)
                    {
                        Console.SetCursorPosition(j, i);
                        switch (gameOverReference.GameOver1reg[i, j])
                        {
                            case "Track":
                                Console.BackgroundColor = ConsoleColor.White;
                                break;
                            case "Grass":
                                Console.BackgroundColor = ConsoleColor.Green;
                                break;
                            case "Wall":
                                Console.BackgroundColor = ConsoleColor.Black;
                                break;
                        }
                        Console.Write(' ');
                    }
                }
                System.Threading.Thread.Sleep(100);
                for (int i = 0; i < 50; i++)
                {
                    for (int j = 0; j < 151; j++)
                    {
                        Console.SetCursorPosition(j, i);
                        switch (gameOverReference.GameOver2Highlight[i, j])
                        {
                            case "Track":
                                Console.BackgroundColor = ConsoleColor.White;
                                break;
                            case "Grass":
                                Console.BackgroundColor = ConsoleColor.Green;
                                break;
                            case "Wall":
                                Console.BackgroundColor = ConsoleColor.Black;
                                break;
                        }
                        Console.Write(' ');
                    }
                }
                System.Threading.Thread.Sleep(100);
            }
            int choice = 0;

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    var key = Console.ReadKey();
                    switch (key.Key)
                    {
                        case ConsoleKey.UpArrow:
                            if (choice < 1) choice++;
                            else choice = 0;
                            break;
                        case ConsoleKey.DownArrow:
                            if (choice > 0) choice++;
                            else choice = 1;
                            break;
                        case ConsoleKey.Enter:
                            if (choice == 0) { Console.Clear(); Program.Main(new string[] { }); }
                            else { Environment.Exit(0); }
                            return;
                    }
                }

                for (int i = 0; i < 50; i++)
                {
                    for (int j = 0; j < 151; j++)
                    {
                        Console.SetCursorPosition(j, i);
                        switch (gameOverReference.GameOver1reg[i, j])
                        {
                            case "Track":
                                Console.BackgroundColor = ConsoleColor.White;
                                break;
                            case "Grass":
                                Console.BackgroundColor = ConsoleColor.Green;
                                break;
                            case "Wall":
                                Console.BackgroundColor = ConsoleColor.Black;
                                break;
                        }
                        Console.Write(' ');
                    }
                }

                if (choice == 0) { Font.print(0, 0, "Play Again"); Font.printHighlight(0, 8, "Quit"); }
                else { Font.printHighlight(0, 0, "Play Again"); Font.print(0, 8, "Quit"); }

            }
        }
    }
}