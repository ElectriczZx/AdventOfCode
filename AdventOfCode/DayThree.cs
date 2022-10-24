using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace AdventOfCode
{
    internal class DayThree
    {
        public class AdventDayThree
        {
            public static void HouseGrid()
            {

                string input = System.IO.File.ReadAllText(@"C:\Users\nisba\source\repos\AdventOfCode\AdventOfCode\TextDayThree.txt"); ;
                var hs = new HashSet<Tuple<int, int>>();
                var SantaPos = new Tuple<int, int>(0, 0);
                var RoboSantaPos = new Tuple<int, int>(0, 0);

                for (int i = 0; i < input.Length; i++)
                {
                    if (i % 2 == 0) //RoboSanta
                    {
                        RoboSantaPos = getNewPos(RoboSantaPos, input[i]);
                        hs.Add(RoboSantaPos);
                    }
                    else SantaPos = getNewPos(SantaPos, input[i]); hs.Add(SantaPos); //SantaSanta
                }
                
                Console.WriteLine(hs.Count);
            }

            public static Tuple<int, int> getNewPos(Tuple<int, int> currentPos, char coord)
            {
                switch (coord)
                {
                    case '<':
                        return new Tuple<int, int>(currentPos.Item1 + 1, currentPos.Item2);
                    case '>':
                        return new Tuple<int, int>(currentPos.Item1 - 1, currentPos.Item2);
                    case '^':
                        return new Tuple<int, int>(currentPos.Item1, currentPos.Item2 + 1);
                    case 'v':
                        return new Tuple<int, int>(currentPos.Item1, currentPos.Item2 - 1);
                    default:
                        throw new FormatException($"Invalid input Data. Valid inputs are: ^ v > <");
                }
            }
        }
    }
}
