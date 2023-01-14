using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Retro_Racer
{
    public class Font
    {
        public static int[,] undef = new int[,] {  {1, 1, 1, 1, 1},
                           {1, 1, 1, 1, 1},
                           {1, 0, 0, 0, 1},
                           {1, 0, 0, 0, 1},
                           {1, 1, 1, 1, 1},
                           {1, 1, 1, 1, 1},
                           {1, 1, 1, 1, 1}  };


        public static int[,] A = new int[,] {  {0, 0, 1, 0, 0},
                           {0, 1, 0, 1, 0},
                           {1, 0, 0, 0, 1},
                           {1, 0, 0, 0, 1},
                           {1, 1, 1, 1, 1},
                           {1, 0, 0, 0, 1},
                           {1, 0, 0, 0, 1}  };

        public static int[,] B = new int[,] {  {1, 1, 1, 1, 0},
                           {1, 0, 0, 0, 1},
                           {1, 0, 0, 0, 1},
                           {1, 1, 1, 1, 0},
                           {1, 0, 0, 0, 1},
                           {1, 0, 0, 0, 1},
                           {1, 1, 1, 1, 0}  };

        public static int[,] C = new int[,] {  {0, 1, 1, 1, 0},
                           {1, 0, 0, 0, 1},
                           {1, 0, 0, 0, 0},
                           {1, 0, 0, 0, 0},
                           {1, 0, 0, 0, 0},
                           {1, 0, 0, 0, 1},
                           {0, 1, 1, 1, 0}  };

        public static int[,] D = new int[,] {  {1, 1, 1, 0, 0},
                           {1, 0, 0, 1, 0},
                           {1, 0, 0, 0, 1},
                           {1, 0, 0, 0, 1},
                           {1, 0, 0, 0, 1},
                           {1, 0, 0, 1, 0},
                           {1, 1, 1, 0, 0}  };

        public static int[,] E = new int[,] {  {1, 1, 1, 1, 1},
                           {1, 0, 0, 0, 0},
                           {1, 0, 0, 0, 0},
                           {1, 1, 1, 1, 1},
                           {1, 0, 0, 0, 0},
                           {1, 0, 0, 0, 0},
                           {1, 1, 1, 1, 1}  };

        public static int[,] F = new int[,] {  {1, 1, 1, 1, 1},
                           {1, 0, 0, 0, 0},
                           {1, 0, 0, 0, 0},
                           {1, 1, 1, 1, 0},
                           {1, 0, 0, 0, 0},
                           {1, 0, 0, 0, 0},
                           {1, 0, 0, 0, 0}  };

        public static int[,] G = new int[,] {  {0, 1, 1, 1, 0},
                           {1, 0, 0, 0, 1},
                           {1, 0, 0, 0, 0},
                           {1, 0, 1, 1, 0},
                           {1, 0, 0, 0, 1},
                           {1, 0, 0, 0, 1},
                           {0, 1, 1, 1, 0}  };

        public static int[,] H = new int[,] {  {1, 0, 0, 0, 1},
                           {1, 0, 0, 0, 1},
                           {1, 0, 0, 0, 1},
                           {1, 1, 1, 1, 1},
                           {1, 0, 0, 0, 1},
                           {1, 0, 0, 0, 1},
                           {1, 0, 0, 0, 1}  };

        public static int[,] I = new int[,] {  {1, 1, 1, 1, 1},
                           {1, 0, 1, 0, 1},
                           {0, 0, 1, 0, 0},
                           {0, 0, 1, 0, 0},
                           {0, 0, 1, 0, 0},
                           {1, 0, 1, 0, 1},
                           {1, 1, 1, 1, 1}  };

        public static int[,] J = new int[,] {  {1, 1, 1, 1, 1},
                           {0, 0, 1, 0, 0},
                           {0, 0, 1, 0, 0},
                           {0, 0, 1, 0, 0},
                           {1, 0, 1, 0, 0},
                           {1, 0, 1, 0, 0},
                           {0, 1, 0, 0, 0}  };

        public static int[,] K = new int[,] {  {1, 0, 0, 0, 1},
                           {1, 0, 0, 1, 0},
                           {1, 0, 1, 0, 0},
                           {1, 1, 0, 0, 0},
                           {1, 0, 1, 0, 0},
                           {1, 0, 0, 1, 0},
                           {1, 0, 0, 0, 1}  };

        public static int[,] L = new int[,] {  {1, 0, 0, 0, 0},
                           {1, 0, 0, 0, 0},
                           {1, 0, 0, 0, 0},
                           {1, 0, 0, 0, 0},
                           {1, 0, 0, 0, 0},
                           {1, 0, 0, 0, 0},
                           {1, 1, 1, 1, 1}  };

        public static int[,] M = new int[,] {  {0, 1, 0, 1, 0},
                           {1, 0, 1, 0, 1},
                           {1, 0, 1, 0, 1},
                           {1, 0, 0, 0, 1},
                           {1, 0, 0, 0, 1},
                           {1, 0, 0, 0, 1},
                           {1, 0, 0, 0, 1}  };

        public static int[,] N = new int[,] {  {1, 0, 0, 0, 1},
                           {1, 1, 0, 0, 1},
                           {1, 1, 0, 0, 1},
                           {1, 0, 1, 0, 1},
                           {1, 0, 1, 0, 1},
                           {1, 0, 0, 1, 1},
                           {1, 0, 0, 1, 1}  };

        public static int[,] O = new int[,] {  {0, 1, 1, 1, 0},
                           {1, 0, 0, 0, 1},
                           {1, 0, 0, 0, 1},
                           {1, 0, 0, 0, 1},
                           {1, 0, 0, 0, 1},
                           {1, 0, 0, 0, 1},
                           {0, 1, 1, 1, 0}  };

        public static int[,] P = new int[,] {  {0, 1, 1, 1, 0},
                           {1, 0, 0, 0, 1},
                           {1, 0, 0, 0, 1},
                           {1, 1, 1, 1, 0},
                           {1, 0, 0, 0, 0},
                           {1, 0, 0, 0, 0},
                           {1, 0, 0, 0, 0}  };

        public static int[,] Q = new int[,] {  {0, 1, 1, 1, 0},
                           {1, 0, 0, 0, 1},
                           {1, 0, 0, 0, 1},
                           {1, 0, 0, 0, 1},
                           {1, 0, 1, 0, 1},
                           {1, 0, 0, 1, 0},
                           {0, 1, 1, 0, 1}  };

        public static int[,] R = new int[,] {  {1, 1, 1, 1, 0},
                           {1, 0, 0, 0, 1},
                           {1, 0, 0, 0, 1},
                           {1, 1, 1, 1, 0},
                           {1, 0, 1, 0, 0},
                           {1, 0, 0, 1, 0},
                           {1, 0, 0, 0, 1}  };

        public static int[,] S = new int[,] {  {0, 1, 1, 1, 0},
                           {1, 0, 0, 0, 1},
                           {1, 0, 0, 0, 0},
                           {0, 1, 1, 1, 0},
                           {0, 0, 0, 0, 1},
                           {1, 0, 0, 0, 1},
                           {0, 1, 1, 1, 0}  };

        public static int[,] T = new int[,] {  {1, 1, 1, 1, 1},
                           {1, 0, 1, 0, 1},
                           {0, 0, 1, 0, 0},
                           {0, 0, 1, 0, 0},
                           {0, 0, 1, 0, 0},
                           {0, 0, 1, 0, 0},
                           {0, 0, 1, 0, 0}  };

        public static int[,] U = new int[,] {  {1, 0, 0, 0, 1},
                           {1, 0, 0, 0, 1},
                           {1, 0, 0, 0, 1},
                           {1, 0, 0, 0, 1},
                           {1, 0, 0, 0, 1},
                           {1, 0, 0, 0, 1},
                           {0, 1, 1, 1, 0}  };

        public static int[,] V = new int[,] {  {1, 0, 0, 0, 1},
                           {1, 0, 0, 0, 1},
                           {0, 1, 0, 1, 0},
                           {0, 1, 0, 1, 0},
                           {0, 1, 0, 1, 0},
                           {0, 1, 0, 1, 0},
                           {0, 0, 1, 0, 0}  };

        public static int[,] W = new int[,] {  {1, 0, 1, 0, 1},
                           {1, 0, 1, 0, 1},
                           {1, 0, 1, 0, 1},
                           {1, 0, 1, 0, 1},
                           {1, 0, 1, 0, 1},
                           {0, 1, 0, 1, 0},
                           {0, 1, 0, 1, 0}  };

        public static int[,] X = new int[,] {  {1, 0, 0, 0, 1},
                           {1, 0, 0, 0, 1},
                           {0, 1, 0, 1, 0},
                           {0, 0, 1, 0, 0},
                           {0, 1, 0, 1, 0},
                           {1, 0, 0, 0, 1},
                           {1, 0, 0, 0, 1}  };

        public static int[,] Y = new int[,] {  {1, 0, 0, 0, 1},
                           {1, 0, 0, 0, 1},
                           {0, 1, 0, 1, 0},
                           {0, 0, 1, 0, 0},
                           {0, 0, 1, 0, 0},
                           {0, 0, 1, 0, 0},
                           {0, 0, 1, 0, 0} };

        public static int[,] Z = new int[,] {  {1, 1, 1, 1, 1},
                           {0, 0, 0, 0, 1},
                           {0, 0, 0, 1, 0},
                           {0, 0, 1, 0, 0},
                           {0, 1, 0, 0, 0},
                           {1, 0, 0, 0, 0},
                           {1, 1, 1, 1, 1}  };

        //LOWERCASE MATRIX BEGIN       


        public static int[,] a = new int[,] {  {0, 0, 0, 0, 0},
                           {0, 0, 0, 0, 0},
                           {0, 1, 1, 1, 0},
                           {0, 0, 0, 1, 0},
                           {0, 1, 1, 1, 0},
                           {0, 1, 0, 1, 0},
                           {0, 1, 1, 0, 1}  };

        public static int[,] b = new int[,] {  {0, 1, 0, 0, 0},
                           {0, 1, 0, 0, 0},
                           {0, 1, 0, 0, 0},
                           {0, 1, 1, 0, 0},
                           {0, 1, 0, 1, 0},
                           {0, 1, 0, 1, 0},
                           {0, 1, 1, 0, 0}  };

        public static int[,] c = new int[,] {  {0, 0, 0, 0, 0},
                           {0, 0, 0, 0, 0},
                           {0, 0, 0, 0, 0},
                           {0, 1, 1, 1, 0},
                           {0, 1, 0, 0, 0},
                           {0, 1, 0, 0, 0},
                           {0, 1, 1, 1, 0}  };

        public static int[,] d = new int[,] {  {0, 0, 0, 1, 0},
                           {0, 0, 0, 1, 0},
                           {0, 0, 0, 1, 0},
                           {0, 0, 1, 1, 0},
                           {0, 1, 0, 1, 0},
                           {0, 1, 0, 1, 0},
                           {0, 0, 1, 1, 0}  };

        public static int[,] e = new int[,] {  {0, 0, 0, 0, 0},
                           {0, 0, 0, 0, 0},
                           {0, 1, 1, 1, 0},
                           {0, 1, 0, 1, 0},
                           {0, 1, 1, 1, 0},
                           {0, 1, 0, 0, 0},
                           {0, 1, 1, 1, 0}  };

        public static int[,] f = new int[,] {  {0, 0, 1, 0, 0},
                           {0, 1, 0, 1, 0},
                           {0, 1, 0, 0, 0},
                           {0, 1, 1, 0, 0},
                           {0, 1, 0, 0, 0},
                           {0, 1, 0, 0, 0},
                           {0, 1, 0, 0, 0}  };

        public static int[,] g = new int[,] {  {0, 0, 0, 0, 0},
                           {0, 1, 1, 1, 0},
                           {0, 1, 0, 1, 0},
                           {0, 1, 1, 1, 0},
                           {0, 0, 0, 1, 0},
                           {0, 1, 0, 1, 0},
                           {0, 0, 1, 0, 0}  };

        public static int[,] hh = new int[,] {  {0, 1, 0, 0, 0},
                           {0, 1, 0, 0, 0},
                           {0, 1, 0, 0, 0},
                           {0, 1, 1, 0, 0},
                           {0, 1, 0, 1, 0},
                           {0, 1, 0, 1, 0},
                           {0, 1, 0, 1, 0}  };

        public static int[,] i = new int[,] {  {0, 0, 0, 0, 0},
                           {0, 0, 1, 0, 0},
                           {0, 0, 0, 0, 0},
                           {0, 0, 1, 0, 0},
                           {0, 0, 1, 0, 0},
                           {0, 0, 1, 0, 0},
                           {0, 1, 1, 1, 0}  };

        public static int[,] jj = new int[,] {  {0, 0, 0, 0, 0},
                           {0, 0, 0, 1, 0},
                           {0, 0, 0, 0, 0},
                           {0, 0, 0, 1, 0},
                           {0, 0, 0, 1, 0},
                           {0, 1, 0, 1, 0},
                           {0, 0, 1, 0, 0}  };

        public static int[,] k = new int[,] {  {0, 1, 0, 0, 0},
                           {0, 1, 0, 0, 0},
                           {0, 1, 0, 1, 0},
                           {0, 1, 0, 1, 0},
                           {0, 1, 1, 0, 0},
                           {0, 1, 0, 1, 0},
                           {0, 1, 0, 1, 0}  };

        public static int[,] l = new int[,] {  {0, 0, 1, 0, 0},
                           {0, 0, 1, 0, 0},
                           {0, 0, 1, 0, 0},
                           {0, 0, 1, 0, 0},
                           {0, 0, 1, 0, 0},
                           {0, 0, 1, 0, 0},
                           {0, 0, 1, 0, 0}  };

        public static int[,] m = new int[,] {  {0, 0, 0, 0, 0},
                           {0, 0, 0, 0, 0},
                           {0, 0, 0, 0, 0},
                           {0, 1, 0, 1, 0},
                           {1, 0, 1, 0, 1},
                           {1, 0, 1, 0, 1},
                           {1, 0, 1, 0, 1}  };

        public static int[,] n = new int[,] {  {0, 0, 0, 0, 0},
                           {0, 0, 0, 0, 0},
                           {0, 0, 0, 0, 0},
                           {0, 0, 1, 0, 0},
                           {0, 1, 0, 1, 0},
                           {0, 1, 0, 1, 0},
                           {0, 1, 0, 1, 0}  };

        public static int[,] o = new int[,] {  {0, 0, 0, 0, 0},
                           {0, 0, 0, 0, 0},
                           {0, 0, 0, 0, 0},
                           {0, 1, 1, 1, 0},
                           {0, 1, 0, 1, 0},
                           {0, 1, 0, 1, 0},
                           {0, 1, 1, 1, 0}  };

        public static int[,] p = new int[,] {  {0, 0, 0, 0, 0},
                           {0, 0, 0, 0, 0},
                           {0, 1, 1, 1, 0},
                           {0, 1, 0, 1, 0},
                           {0, 1, 1, 1, 0},
                           {0, 1, 0, 0, 0},
                           {0, 1, 0, 0, 0}  };

        public static int[,] q = new int[,] {  {0, 0, 0, 0, 0},
                           {0, 0, 0, 0, 0},
                           {0, 1, 1, 1, 0},
                           {0, 1, 0, 1, 0},
                           {0, 1, 1, 1, 0},
                           {0, 0, 0, 1, 0},
                           {0, 0, 0, 1, 0}  };

        public static int[,] r = new int[,] {  {0, 0, 0, 0, 0},
                           {0, 0, 0, 0, 0},
                           {0, 0, 0, 0, 0},
                           {0, 0, 1, 1, 0},
                           {0, 1, 0, 0, 0},
                           {0, 1, 0, 0, 0},
                           {0, 1, 0, 0, 0}  };

        public static int[,] s = new int[,] {  {0, 0, 0, 0, 0},
                           {0, 0, 0, 0, 0},
                           {0, 1, 1, 1, 0},
                           {1, 0, 0, 0, 0},
                           {0, 1, 1, 1, 0},
                           {0, 0, 0, 0, 1},
                           {0, 1, 1, 1, 0}  };

        public static int[,] t = new int[,] {  {0, 0, 1, 0, 0},
                           {0, 0, 1, 0, 0},
                           {0, 0, 1, 0, 0},
                           {0, 1, 1, 1, 0},
                           {0, 0, 1, 0, 0},
                           {0, 0, 1, 0, 0},
                           {0, 0, 1, 0, 0}  };

        public static int[,] u = new int[,] {  {0, 0, 0, 0, 0},
                           {0, 0, 0, 0, 0},
                           {0, 0, 0, 0, 0},
                           {0, 1, 0, 1, 0},
                           {0, 1, 0, 1, 0},
                           {0, 1, 0, 1, 0},
                           {0, 0, 1, 0, 1}  };

        public static int[,] v = new int[,] {  {0, 0, 0, 0, 0},
                           {0, 0, 0, 0, 0},
                           {0, 0, 0, 0, 0},
                           {0, 1, 0, 1, 0},
                           {0, 1, 0, 1, 0},
                           {0, 1, 0, 1, 0},
                           {0, 0, 1, 0, 0}  };

        public static int[,] w = new int[,] {  {0, 0, 0, 0, 0},
                           {0, 0, 0, 0, 0},
                           {0, 0, 0, 0, 0},
                           {0, 0, 0, 0, 0},
                           {1, 0, 1, 0, 1},
                           {1, 0, 1, 0, 1},
                           {0, 1, 0, 1, 0}  };

        public static int[,] xx = new int[,] {  {0, 0, 0, 0, 0},
                           {0, 0, 0, 0, 0},
                           {0, 1, 0, 1, 0},
                           {0, 1, 0, 1, 0},
                           {0, 0, 1, 0, 0},
                           {0, 1, 0, 1, 0},
                           {0, 1, 0, 1, 0}  };

        public static int[,] yy = new int[,] {  {0, 0, 0, 0, 0},
                           {0, 1, 0, 1, 0},
                           {0, 1, 0, 1, 0},
                           {0, 1, 1, 1, 0},
                           {0, 0, 0, 1, 0},
                           {0, 1, 0, 1, 0},
                           {0, 0, 1, 0, 0} };

        public static int[,] z = new int[,] {  {0, 0, 0, 0, 0},
                           {0, 0, 0, 0, 0},
                           {0, 1, 1, 1, 0},
                           {0, 0, 0, 1, 0},
                           {0, 0, 1, 0, 0},
                           {0, 1, 0, 0, 0},
                           {0, 1, 1, 1, 0}  };

        public static void print(int x, int y, string text)
        {
            var length = text.Length;
            // for (int Letter = 0; Letter < length; Letter++)
            for (var i = 0; i < A.GetLength(0); i++)
            {
                y += 1;
                int t = x;
                for (var j = 0; j < A.GetLength(1); j++)
                {
                    t += 1;
                    if (a[i, j] == 1)
                    {
                        Console.SetCursorPosition(x + t, y);
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.Write(" ");

                        //   sand->setPixel(x + t, y);     

                    }
                }

            }
        }
    }



    // switch (text[Letter])
    // {
    //     case 'a':
    //         if (a[h, j] == 1)
    //             Console.SetCursorPosition(x + j + Letter * 5, y + h);
    //         Console.Write("X");
    //         break;
    //     case 'b':
    //         if (b[h, j] == 1)
    //             Console.SetCursorPosition(x + j + Letter * 5, y + h);
    //         Console.Write("X");
    //         break;
    //     case 'c':
    //         if (c[h, j] == 1)
    //             Console.SetCursorPosition(x + j + Letter * 5, y + h);
    //         Console.Write("X");
    //         break;
    //     case 'd':
    //         if (d[h, j] == 1)
    //             Console.SetCursorPosition(x + j + Letter * 5, y + h);
    //         Console.Write("X");
    //         break;
    //     case 'e':
    //         if (e[h, j] == 1)
    //             Console.SetCursorPosition(x + j + Letter * 5, y + h);
    //         Console.Write("X");
    //         break;
    //     case 'f':
    //         if (f[h, j] == 1)
    //             Console.SetCursorPosition(x + j + Letter * 5, y + h);
    //         Console.Write("X");
    //         break;
    //     case 'g':
    //         if (g[h, j] == 1)
    //             Console.SetCursorPosition(x + j + Letter * 5, y + h);
    //         Console.Write("X");
    //         break;
    //     case 'h':
    //         if (hh[h, j] == 1)
    //             Console.SetCursorPosition(x + j + Letter * 5, y + h);
    //         Console.Write("X");
    //         break;
    //     case 'i':
    //         if (i[h, j] == 1)
    //             Console.SetCursorPosition(x + j + Letter * 5, y + h);
    //         Console.Write("X");
    //         break;
    //     case 'j':
    //         if (jj[h, j] == 1)
    //             Console.SetCursorPosition(x + j + Letter * 5, y + h);
    //         Console.Write("X");
    //         break;
    //     case 'k':
    //         if (k[h, j] == 1)
    //             Console.SetCursorPosition(x + j + Letter * 5, y + h);
    //         Console.Write("X");
    //         break;
    //     case 'l':
    //         if (l[h, j] == 1)
    //             Console.SetCursorPosition(x + j + Letter * 5, y + h);
    //         Console.Write("X");
    //         break;
    //     case 'm':
    //         if (m[h, j] == 1)
    //             Console.SetCursorPosition(x + j + Letter * 5, y + h);
    //         Console.Write("X");
    //         break;
    //     case 'n':
    //         if (n[h, j] == 1)
    //             Console.SetCursorPosition(x + j + Letter * 5, y + h);
    //         Console.Write("X");
    //         break;
    //     case 'o':
    //         if (o[h, j] == 1)
    //             Console.SetCursorPosition(x + j + Letter * 5, y + h);
    //         Console.Write("X");
    //         break;
    //     case 'p':
    //         if (p[h, j] == 1)
    //             Console.SetCursorPosition(x + j + Letter * 5, y + h);
    //         Console.Write("X");
    //         break;
    //     case 'q':
    //         if (q[h, j] == 1)
    //             Console.SetCursorPosition(x + j + Letter * 5, y + h);
    //         Console.Write("X");
    //         break;
    //     case 'r':
    //         if (r[h, j] == 1)
    //             Console.SetCursorPosition(x + j + Letter * 5, y + h);
    //         Console.Write("X");
    //         break;
    //     case 's':
    //         if (s[h, j] == 1)
    //             Console.SetCursorPosition(x + j + Letter * 5, y + h);
    //         Console.Write("X");
    //         break;
    //     case 't':
    //         if (t[h, j] == 1)
    //             Console.SetCursorPosition(x + j + Letter * 5, y + h);
    //         Console.Write("X");
    //         break;
    //     case 'u':
    //         if (u[h, j] == 1)
    //             Console.SetCursorPosition(x + j + Letter * 5, y + h);
    //         Console.Write("X");
    //         break;
    //     case 'v':
    //         if (v[h, j] == 1)
    //             Console.SetCursorPosition(x + j + Letter * 5, y + h);
    //         Console.Write("X");
    //         break;
    //     case 'w':
    //         if (w[h, j] == 1)
    //             Console.SetCursorPosition(x + j + Letter * 5, y + h);
    //         Console.Write("X");
    //         break;
    //     case 'x':
    //         if (xx[h, j] == 1)
    //             Console.SetCursorPosition(x + j + Letter * 5, y + h);
    //         Console.Write("X");
    //         break;
    //     case 'y':
    //         if (yy[h, j] == 1)
    //             Console.SetCursorPosition(x + j + Letter * 5, y + h);
    //         Console.Write("X");
    //         break;
    //     case 'z':
    //         if (z[h, j] == 1)
    //             Console.SetCursorPosition(x + j + Letter * 5, y + h);
    //         Console.Write("X");
    //         break;

}