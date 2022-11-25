using System.Text.RegularExpressions;

namespace AdventOfCode
{
    public class AdventDayFive
    {
        public static void niceString()
        {
            string[] input = Inputstrg.InputDataSArray(5, 1);
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            string[] badVowels = { "ab", "cd", "pq", "xy" };
            int niceStrings = 0;

            foreach (string line in input)
            {
                bool isDoubleLetter = false;
                char[] splitLine = line.ToCharArray(0, line.Length);
                for (int i = 1; i < splitLine.Length; i++)
                {
                    if (splitLine[i] == splitLine[i - 1])
                    {
                        isDoubleLetter = true;
                        continue;
                    }
                }
                int vCount = line.Count(c => vowels.Contains(c));
                if (vCount >= 3 && !badVowels.Any(line.Contains) && isDoubleLetter)
                {
                    niceStrings++;
                }

                Console.WriteLine(niceStrings);

            }
        }

        public static void niceStringPT()
        {
            string[] input = Inputstrg.InputDataSArray(5, 1);
            int niceStrings = 0;

            foreach (string line in input)
            {
                bool isDouble = false;
                char[] splitLine = line.ToCharArray(0, line.Length);
                string ab = "";
                int counter = 0;


                for (int i = 2; i < splitLine.Length; i++)
                {
                    if (splitLine[i] == splitLine[i - 2])
                    {
                        isDouble = true;
                        continue;
                    }
                }
                for (int i = 0; i < splitLine.Length - 1; i++)
                {
                    ab += splitLine[i];
                    ab += splitLine[i + 1];
                    if (splitLine.Length < splitLine.Length)
                    {
                        if (splitLine[i + 2] == ab[0] && splitLine[i + 2] == ab[1])
                        {
                            continue;
                        }
                    }
                    if (Regex.Matches(line, ab).Count >= 2)
                    {
                        counter++;
                        ab = "";
                    }
                    if (counter == 2 && isDouble)
                    {
                        niceStrings++;
                        break;
                    }
                    ab = "";
                }

                Console.WriteLine(niceStrings);

            }
        }

    }
}
