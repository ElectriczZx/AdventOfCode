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
                int day = 1;
                int sub = 1;
                string textIn = Inputstrg.InputData(day, sub);
                AdventDAO.setInputForDaySub(day, sub, textIn);
                string text = AdventDAO.getInputForDaySub(day, sub) ?? "";
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

                Console.WriteLine("floor: " + floor);

            }
        }
    }
}
