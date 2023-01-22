using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Retro_Racer
{
    public class RacerSprites
    {
        public static int[,] car45ULDR = new int[,]
{
{0, 0, 1, 1, 0, 0, 0} ,
{0, 1, 1, 0, 0, 0, 0} ,
{1, 1, 1, 1, 0, 0, 0} ,
{1, 0, 1, 1, 1, 0, 1} ,
{0, 0, 0, 1, 1, 1, 1} ,
{0, 0, 0, 0, 1, 1, 0},
{0, 0, 0, 1, 1, 0, 0}
};

        public static int[,] car45DLUR = new int[,]
{
{0, 0, 0, 1, 1, 0, 0},
{0, 0, 0, 0, 1, 1, 0},
{0, 0, 0, 1, 1, 1, 1},
{1, 0, 1, 1, 1, 0, 1},
{1, 1, 1, 1, 0, 0, 0},
{0, 1, 1, 0, 0, 0, 0},
{0, 0, 1, 1, 0, 0, 0}

};

        public static int[,] carLR = new int[,]
        {
{0, 0, 0, 0, 0, 0, 0},
{1, 1, 0, 0, 0, 1, 1},
{1, 1, 0, 0, 0, 1, 1},
{0, 1, 1, 1, 1, 1, 0},
{1, 1, 0, 0, 0, 1, 1},
{1, 1, 0, 0, 0, 1, 1},
{0, 0, 0, 0, 0, 0, 0}

        };


        public static int[,] carUD = new int[,]{
    {0, 1, 1, 0, 1, 1, 0},
    {0, 1, 1, 1, 1, 1, 0},
    {0, 0, 0, 1, 0, 0, 0},
    {0, 0, 0, 1, 0, 0, 0},
    {0, 0, 0, 1, 0, 0, 0},
    {0, 1, 1, 1, 1, 1, 0},
    {0, 1, 1, 0, 1, 1, 0}};


        public static int[,] car25LDRUB45 = new int[,] {
{0, 0, 1, 1, 0, 0, 0},
{0, 0, 0, 1, 1, 1, 0},
{0, 0, 0, 1, 1, 1, 1},
{0, 0, 1, 1, 1, 0, 0},
{1, 1, 1, 1, 0, 0, 0},
{0, 1, 1, 1, 0, 0, 0},
{0, 0, 0, 1, 1, 0, 0}};
        public static int[,] car25LURDA45 = new int[,] {
{0, 0, 0, 1, 1, 0, 0},
{0, 1, 1, 1, 0, 0, 0},
{1, 1, 1, 1, 0, 0, 0},
{0, 0, 1, 1, 1, 0, 0},
{0, 0, 0, 1, 1, 1, 1},
{0, 0, 0, 1, 1, 1, 0},
{0, 0, 1, 1, 0, 0, 0}
};
        public static int[,] car25LURDB45 = new int[,]{
{0, 0, 1, 0, 0, 0, 0},
{0, 1, 1, 0, 0, 0, 0},
{0, 1, 1, 1, 0, 0, 1},
{1, 1, 1, 1, 1, 1, 1},
{1, 0, 0, 1, 1, 1, 0},
{0, 0, 0, 0, 1, 1, 0},
{0, 0, 0, 0, 1, 0, 0}
};

        public static int[,] car25LDRUA45 = new int[,]
            {{0, 0, 0, 0, 1, 0, 0},
     {0, 0, 0, 0, 1, 1, 0},
     {1, 0, 0, 1, 1, 1, 0},
     {1, 1, 1, 1, 1, 1, 1},
     {0, 1, 1, 1, 0, 0, 1},
     {0, 1, 1, 0, 0, 0, 0},
     {0, 0, 1, 0, 0, 0, 0}};


        public static void showSprite(int x, int y, int spriteNumber, (int x, int y) curTack, trackHandler TrackHandlerC)
        {
            var one = carUD; // Start UpDown
            var two = car25LDRUB45;
            var three = car45DLUR;
            var four = car25LDRUA45;
            var five = carLR; //Top going Right
            var six = car25LURDB45; // NEEDS REVIEW
            var seven = car45ULDR;
            var eight = car25LURDA45;
            var nine = carUD; // Opposite of start going down
            var ten = car25LDRUB45;
            var eleven = car45DLUR;
            var twelve = car25LDRUA45;
            var thirteen = carLR; //Bottom going Left
            var fourteen = car25LURDB45;
            var fifteen = car45ULDR;
            var sixteen = car25LURDA45;

            var current = new int[,] { };
            var previous = new int[,] { };

            int prevNumber = 0;

            if (spriteNumber != 1) prevNumber = spriteNumber - 1;
            else prevNumber = 16;

            //Maybe make these smaller somehow using lambdas?

            switch (spriteNumber)
            {
                case 1:
                    current = one;
                    break;
                case 2:
                    current = two;
                    break;
                case 3:
                    current = three;
                    break;
                case 4:
                    current = four;
                    break;
                case 5:
                    current = five;
                    break;
                case 6:
                    current = six;
                    break;
                case 7:
                    current = seven;
                    break;
                case 8:
                    current = eight;
                    break;
                case 9:
                    current = nine;
                    break;
                case 10:
                    current = ten;
                    break;
                case 11:
                    current = eleven;
                    break;
                case 12:
                    current = twelve;
                    break;
                case 13:
                    current = thirteen;
                    break;
                case 14:
                    current = fourteen;
                    break;
                case 15:
                    current = fifteen;
                    break;
                case 16:
                    current = sixteen;
                    break;
            }

            switch (prevNumber)
            {
                case 1:
                    previous = one;
                    break;
                case 2:
                    previous = two;
                    break;
                case 3:
                    previous = three;
                    break;
                case 4:
                    previous = four;
                    break;
                case 5:
                    previous = five;
                    break;
                case 6:
                    previous = six;
                    break;
                case 7:
                    previous = seven;
                    break;
                case 8:
                    previous = eight;
                    break;
                case 9:
                    previous = nine;
                    break;
                case 10:
                    previous = ten;
                    break;
                case 11:
                    previous = eleven;
                    break;
                case 12:
                    previous = twelve;
                    break;
                case 13:
                    previous = thirteen;
                    break;
                case 14:
                    previous = fourteen;
                    break;
                case 15:
                    previous = fifteen;
                    break;
                case 16:
                    previous = sixteen;
                    break;
            }

            var checkedx = curTack.x / 100;
            var checkedy = curTack.y / 100;

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.SetCursorPosition(x + j, y + i);
                    if (i == 3 && j == 3)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("X");
                    }
                    else
                    {

                        if (current[i, j] == 1)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Write(" ");
                        }
                        else
                        {
                            switch (TrackHandlerC.currentTrack[checkedy + i, checkedx + j])
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
                            }
                            System.Console.Write(' ');
                        }
                    }
                }

            }

        }
        public static int[,] racerSpriteC(int number)
        {
            var one = carUD; // Start UpDown
            var two = car25LDRUB45;
            var three = car45DLUR;
            var four = car25LDRUA45;
            var five = carLR; //Top going Right
            var six = car25LURDB45;
            var seven = car45ULDR;
            var eight = car25LURDA45;
            var nine = carUD; // Opposite of start going down
            var ten = car25LDRUB45;
            var eleven = car45DLUR;
            var twelve = car25LDRUA45;
            var thirteen = carLR; //Bottom going Left
            var fourteen = car25LURDB45;
            var fifteen = car45ULDR;
            var sixteen = car25LURDA45;
            switch (number)
            {
                case 1:
                    return one;

                case 2:
                    return two;

                case 3:
                    return three;

                case 4:
                    return four;

                case 5:
                    return five;

                case 6:
                    return six;

                case 7:
                    return seven;

                case 8:
                    return eight;

                case 9:
                    return nine;

                case 10:
                    return ten;

                case 11:
                    return eleven;

                case 12:
                    return twelve;

                case 13:
                    return thirteen;

                case 14:
                    return fourteen;

                case 15:
                    return fifteen;

                case 16:
                    return sixteen;

            }

            return new int[0, 0]; // Welp if you do not have a good number that is your problem...

        }
    }
}