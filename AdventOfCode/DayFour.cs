using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace AdventOfCode
{
    internal class DayFour
    {

    }

    public class AdventDayFour
    {
        public static void Santa()
        {

            string input = "ckczppom";
            string hex = "";
            int num = 0;
            string firstFive = "";
            string input2 = "";


            while (firstFive != "000000")
            {
                     input2 = input + num;
                     MD5 md5 = MD5.Create();
                    {
                        byte[] inputBytes = Encoding.ASCII.GetBytes(input2);
                        byte[] hashBytes = md5.ComputeHash(inputBytes);

                        hex = Convert.ToHexString(hashBytes);
                }
                firstFive = new string(hex.Take(6).ToArray());

                num++;
            }

            System.Console.WriteLine(num-1);
            System.Console.WriteLine(hex);
        }
    }
}
