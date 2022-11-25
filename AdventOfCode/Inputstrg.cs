using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    public class Inputstrg
    {

        public static string InputData(int day, int sub)
        {
            switch (day, sub)
            {
                case (1, 1):
                    return File.ReadAllText(@"C:\Users\nisba\source\repos\AdventOfCode\AdventOfCode\TextDayOne.txt");
                case (3, 1):
                    return File.ReadAllText(@"C:\Users\nisba\source\repos\AdventOfCode\AdventOfCode\TextDayThree.txt");
                case (4, 1):
                    return "ckczppom";
                default:
                    throw new FormatException($"Invalid input Data.");
            }
        }

        public static string[] InputDataSArray(int day, int sub)
        {
            switch (day, sub)
            {
                case (5, 1):
                    var input = File.ReadAllLines(@"C:\Users\nisba\source\repos\AdventOfCode\AdventOfCode\TextDayFive.txt");
                    return input;
                default:
                    throw new FormatException($"Invalid input Data.");
            }
        }


    }
}