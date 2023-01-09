using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Retro_Racer
{
    public class trackConverter
    {
        public static void convertTrack()
        {

            string pathToCurrent = Directory.GetCurrentDirectory();
            string targetPath = pathToCurrent + "\\input";
            var info = new DirectoryInfo(pathToCurrent + "\\input");
            var fileInfo = info.GetFiles();
            Environment.CurrentDirectory = targetPath;

            System.Console.WriteLine("Now setting colors used, give in example (0xffRRGGB -> 0xff00ff42)");
            System.Console.WriteLine("Please Enter Track Color: (Hex)");
            var trackColor = Console.ReadLine() ?? "";
            System.Console.WriteLine("Please Enter Wall Color: (Hex)");


            StreamWriter sw = new StreamWriter("output.txt");

            foreach (var file in fileInfo)
            {
                var name = file.Name;
                if (name == "output.txt") continue;

                var counter = 0;

                if (File.Exists(name)) System.Console.WriteLine("File exists");
                else return;

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

                sw.Write("public static string[,] " + name + " = new string[,] { \n");

                for (int i = 0; i < readable.Count; i++)
                {
                    var line = readable[i];
                    var each = line.Split(' ');

                    foreach (var set in each)
                    {
                        if (counter != each.Count() - 1)
                        {
                            if(set.Contains("0xff000000")) sw.Write("\"Wall\", ");
                            else if(set.Contains("0xffffffff")) sw.Write("\"Track\", ");
                            else if(set.contains("0xff0ff42") || set.Contains("0xff42ff00")) sw.Write("\"Grass\", ");
                            else sw.Write("\"Unknown\", ");
                            // switch (set.TrimEnd(','))
                            // {
                            //     case "0xff000000":
                            //         sw.Write("\"Wall\", ");
                            //         break;
                            //     case "0xffffffff":
                            //         sw.Write("\"Track\", ");
                            //         break;
                            //     case "0xff00ff42":
                            //         sw.Write("\"Grass\", ");
                            //         break;
                            //     default:
                            //         sw.Write("\"Unknown\", ");
                            //         break;
                            // }
                        }
                        if (counter == each.Count() - 1)
                        {
                            if(set.Contains("0xff000000")) sw.Write("\"Wall\" }, ");
                            else if(set.Contains("0xffffffff")) sw.Write("\"Track\" }, ");
                            else if(set.contains("0xff0ff42") || set.Contains("0xff42ff00")) sw.Write("\"Grass\" }, ");
                            else sw.Write("\"Unknown\" }, ");

                            // switch (set.TrimEnd(','))
                            // {
                            //     case "0xff000000":
                            //         sw.Write("\"Wall\" },  ");
                            //         break;
                            //     case "0xffffffff":
                            //         sw.Write("\"Track\" },  ");
                            //         break;
                            //     case "0xff00ff42":
                            //         sw.Write("\"Grass\" },  ");
                            //         break;
                            //     default:
                            //         sw.Write("\"Unknown\" }, ");
                            //         break;
                            // }
                            sw.WriteLine();
                        }
                        counter++;
                    }
                    counter = 0;
                    sw.Write('{');
                }
                sw.Write("};");
                sw.WriteLine();
            }

            sw.Close();
        }
    }
}