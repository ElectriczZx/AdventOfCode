using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class DayTwo
    {
        public class AdventDayTwo
        {
            public static void Elves()
            {
                int totalPaper = 0;
                foreach (string line in File.ReadLines(@"C:\Users\nisba\source\repos\AdventOfCode\AdventOfCode\TextDayTwo.txt"))
                {
                    totalPaper += CalcLines(line);
                }
                Console.WriteLine("Paper: " + totalPaper);
            }

            public static void ElvesRibbon()
            {
                int totalRibbon = 0;
                foreach (string line in File.ReadLines(@"C:\Users\nisba\source\repos\AdventOfCode\AdventOfCode\TextDayTwo.txt"))
                {
                    totalRibbon += CalcLinesRibbon(line);
                }
                Console.WriteLine("Ribbon: " + totalRibbon);
            }

            private static int CalcLines(string line)
            {
                var split = line.Split('x');
                int l = Convert.ToInt32(split[0]);
                int w = Convert.ToInt32(split[1]);
                int h = Convert.ToInt32(split[2]);

                int[] A = new int[3];
                A[0] = 2 * l * w;
                A[1] = 2 * w * h;
                A[2] = 2 * h * l;

                int Area = A[0] + A[1] + A[2];
                int smallest = A.Min()/2;
                int totalSize = Area + smallest;

                return totalSize;
            }

            private static int CalcLinesRibbon(string line)
            {
                var split = line.Split('x');
                int l = Convert.ToInt32(split[0]);
                int w = Convert.ToInt32(split[1]);
                int h = Convert.ToInt32(split[2]);

                int[] A = new int[3];
                A[0] = l;
                A[1] = w;
                A[2] = h;

                A = A.OrderBy(s => s).ToArray();
                int ribbonLenght = 2*A[0] + 2*A[1] + (A[0]*A[1]*A[2]);
                return ribbonLenght;

            }
        }
    }
}
