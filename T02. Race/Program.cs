using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace T02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<name>[A-Za-z])?(?<distance>\d)?";

            string[] validNames = Console.ReadLine()
                .Split(", ");

            Dictionary<string, int> competitorsAndTheirDistance = new Dictionary<string, int>();

            foreach (string name in validNames)
            {
                competitorsAndTheirDistance.Add(name, 0);
            }

            string input = Console.ReadLine();

            while (input != "end of race")
            {
                Match currMatch = Regex.Match(input, pattern);

                if (currMatch.Success)
                {
                    string name = currMatch.Groups["name"].Value;
                    int distance = int.Parse(currMatch.Groups["distance"].Value);

                    if (!validNames.Contains(name))
                    {
                        input = Console.ReadLine();
                        continue;
                    }

                    competitorsAndTheirDistance[name] += distance;
                }

                input = Console.ReadLine();
            }

            var result = competitorsAndTheirDistance.OrderByDescending(x => x.Value).Take(3);

            int count = 1;

            foreach (var item in result)
            {
                string place = count == 1 ? "st" : count == 2 ? "nd" : "rd";
                Console.WriteLine($"{count}{place} place: {item.Key}");
                count++;
            }
        }
    }
}
