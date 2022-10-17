using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    internal class DayOne
    {
        public class AdventDayOne
        {
            public static void Santa()
            {

                int floor = 0;
                int pos = 0;
                string text = System.IO.File.ReadAllText(@"C:\Users\nisba\source\repos\AdventOfCode\AdventOfCode\TextDayOne.txt");
                foreach (char c in text)
                {
                    pos++;
                    if (c == '(')
                    {
                        floor++;
                    }
                    else { floor--; }
                    if (floor == -1)
                    {
                        Console.WriteLine("Basement at position: " + pos);
                    }
                }

                System.Console.WriteLine("floor: " + floor);

            }
        }
    }
}
