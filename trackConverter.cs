using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Retro_Racer
{
    public class trackConverter
    {
        public static void convertTrack(string[,] track)
        {
            var counter = 0;
            var lines = File.ReadAllText("input.txt").Split(' ');
            StreamWriter sw = new StreamWriter("output.txt");



            sw.Write("{ ");

            for (int i = 0; i < lines.Length; i++)
            {

                if (counter == 0) sw.Write("{");
                if (counter != 263) sw.Write(lines[i]);
                if (counter == 263)
                {
                    var trimmed = lines[i].TrimEnd(',');
                    sw.Write(trimmed);
                    sw.Write("}, ");
                }
                counter++;
                if (counter == 264) counter = 0;

            }
            sw.Write("};");
            sw.Close();
        }
    }
}