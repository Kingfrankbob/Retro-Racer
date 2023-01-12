using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Runtime.InteropServices;


namespace Retro_Racer
{
    public class trackConverter
    {
        public static void convertTrack()
        {

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();

            string pathToCurrent = Directory.GetCurrentDirectory();
            string targetPath = "";

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) targetPath = "\\input";
            else targetPath = "\\input";

            var info = new DirectoryInfo(pathToCurrent + targetPath);


            var fileInfo = info.GetFiles();
            var fileCounter = 0;
            var totalFiles = info.EnumerateFiles().Count();

            Environment.CurrentDirectory = targetPath;

            string[] ignore = new string[] { "png", "jpg", "txt", "cs", "jpeg" };

            string trackColor = "asdfasdf";
            string wallColor = "fdasfdsa";
            string grassColor = "asdffdsa";
            string startColor = "fdsaasdf";

            Console.WriteLine(@"Now setting colors, give in Hex format -> example (0xffBBGGRR -> 0xff00ff42)
            
The current pre-programmed colors are:
0xffffffff as Track (White)
0xff000000 as Wall (Black)
0xff00ff42 as Grass (Shade of Green)
~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

NOTE:
ALL FILE CONTENTS OF 'output.cs' WILL BE OVERWRITTEN, MAKE SURE YOU HAVE SAVED CURRENT WORK!!!
When you finish converting you will be taken back to the title screen...

~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

Would you like to set custom, or use pre-programmed?
1. Current
2. Custom");
            try
            {
                switch (int.Parse(Console.ReadLine() ?? ""))
                {
                    case 1:
                        Console.WriteLine("Pre-Programmed Selected!");
                        trackColor = "0xffffffff";
                        wallColor = "0xff000000";
                        grassColor = "0xff42ff00";
                        startColor = "0xff0000ff";
                        break;

                    case 2:
                        Console.WriteLine("Please Enter Track Color: (Hex)"); // DEFAULT TO ORIGINAL COLORS
                        trackColor = Console.ReadLine() ?? "0xff000000";
                        Console.WriteLine("Please Enter Wall Color: (Hex)");
                        wallColor = Console.ReadLine() ?? "0xffffffff";
                        Console.WriteLine("Please Enter Grass Color: (Hex)");
                        grassColor = Console.ReadLine() ?? "0xff42ff00";
                        Console.WriteLine("Please Enter Start Color: (Hex)");
                        startColor = Console.ReadLine() ?? "0xff0000ff";
                        Console.WriteLine("Note: if by any chance you messed up, please press 'ctrl+c' and try again \nIf not the results could be terrible and/or not as expected");
                        break;
                }
            }

            catch (Exception)
            {
                Console.WriteLine("Please, no time to waste, rerun the whole thing again... ERROR");
                convertTrack();
            }

            StreamWriter sw = new StreamWriter("output.cs");

            sw.WriteLine("namespace Retro_Racer\n{\n    class importedMaps\n    {\n");

            foreach (var file in fileInfo)
            {
                var name = file.Name;
                var nextName = name.Replace('.', ' ').Replace('(', ' ').Replace(')', ' ').Replace('-', ' ').Replace('_', ' ');
                var cleanedName = String.Concat(nextName.Where(c => !Char.IsWhiteSpace(c)));
                if (ignore.Contains(name.Split('.')[1]) || name == "output.cs") continue;
                var startX = new List<int>();
                var startY = new List<int>();

                var counter = 0;

                if (File.Exists(name)) Console.WriteLine("File exists");
                else { Console.WriteLine("Somehow the code is broken?"); return; }

                var lines = File.ReadAllLines(name);
                var readable = new List<string>();
                var width = 0;
                var height = 0;

                for (int i = 0; i < lines.Length; i++)
                {
                    var line = lines[i];
                    if (line.Contains("0x")) readable.Add(line);
                    if (line.Contains("WIDTH")) width = int.Parse(line.Split(' ')[2]);
                    if (line.Contains("HEIGHT")) height = int.Parse(line.Split(' ')[2]);
                }

                sw.WriteLine("// Width: " + width + " Height: " + height + " Map Conversion Number: " + fileCounter + " Uncleaned Name: " + name);
                sw.Write("public static string[,] " + cleanedName + " = new string[,] {\n    {");

                Console.WriteLine("Name: {0}, Width: {1}, Height: {2}, Map#: {3}", name, width, height, fileCounter);

                bool newLine = false;

                for (int i = 0; i < readable.Count; i++)
                {
                    var line = readable[i];
                    var each = new string[] { };
                    if (i != readable.Count - 1)
                    {
                        each = line.Split(' ');
                        each = each.Where((item, index) => index != each.Length - 1).ToArray();
                    }
                    else { each = line.Split(' '); }

                    foreach (var set in each)
                    {
                        if (counter < each.Count() - 1)
                        {
                            if (set.Contains(wallColor)) sw.Write("\"Wall\", ");
                            else if (set.Contains(trackColor)) sw.Write("\"Track\", ");
                            else if (set.Contains(grassColor) || set.Contains("0xff00ff42")) sw.Write("\"Grass\", ");
                            else if (set.Contains(startColor)) { sw.Write("\"Start\", "); startX.Add(counter); startY.Add(i); }
                            else sw.Write("\"Unknown\", ");
                        }
                        if (counter == each.Count() - 1 && i != readable.Count - 1)
                        {

                            if (set.Contains(wallColor)) sw.Write("\"Wall\" }, ");
                            else if (set.Contains(trackColor)) sw.Write("\"Track\" }, ");
                            else if (set.Contains(grassColor) || set.Contains("0xff00ff42")) sw.Write("\"Grass\" }, ");
                            else if (set.Contains(startColor)) { sw.Write("\"Start\" }, "); startX.Add(counter); startY.Add(i); }
                            else sw.Write("\"Unknown\" }, ");
                            sw.WriteLine();
                            newLine = true;
                        }
                        if (counter == each.Count() - 1 && i == readable.Count - 1)
                        {
                            if (set.Contains(wallColor)) sw.Write("\"Wall\" } ");
                            else if (set.Contains(trackColor)) sw.Write("\"Track\" } ");
                            else if (set.Contains(grassColor) || set.Contains("0xff00ff42")) sw.Write("\"Grass\" } ");
                            else if (set.Contains(startColor)) { sw.Write("\"Start\" } "); startX.Add(counter); startY.Add(i); }
                            else sw.Write("\"Unknown\" } ");
                            sw.WriteLine();
                            newLine = false;
                        }

                        counter++;
                    }
                    counter = 0;
                    if (counter != each.Count() - 1 && newLine) sw.Write("   {");
                }
                counter = 0;
                sw.Write("    }; // Start is at (" + startX + ", " + startY + ")"); // LOLZ
                sw.WriteLine();
                sw.Write("    public static int[]" + cleanedName + "StartX = new int[]" + "{");
                foreach (var item in startX) { sw.Write(item); if (counter != startY.Count - 1) sw.Write(", "); counter++; }
                sw.Write("};\n");
                counter = 0;
                sw.Write("    public static int[]" + cleanedName + "StartY = new int[]" + "{");
                foreach (var item in startY) { sw.Write(item); if (counter != startY.Count - 1) sw.Write(", "); counter++; }
                sw.Write("};\n");
                sw.WriteLine();
                fileCounter++;
            }
            sw.WriteLine(@"   }
}");
            sw.Close();

            // Program.Main(new string[0]);
        }
    }
}