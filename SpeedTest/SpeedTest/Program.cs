using System;
using System.Diagnostics;
using System.Linq;

namespace SpeedTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select the number from the following list of possible tests:");

            foreach (var item in RegisterOfTypes.DictoraryOfTypes)
            {
                Console.WriteLine(item.Key);
            }

            var selection = Console.ReadLine();

            var dictonaryItemToActOn = RegisterOfTypes.DictoraryOfTypes.First(x => x.Key.Contains(selection));

            var sw = Stopwatch.StartNew();

            var count = 0;

            Console.Write("Run: 0 times");
            while(sw.Elapsed.Seconds < 5)
            {
                dictonaryItemToActOn.Value.Act();
                count++;
                Console.Write("\rRun: {0} times", count);
            }

            
        }
    }
}
