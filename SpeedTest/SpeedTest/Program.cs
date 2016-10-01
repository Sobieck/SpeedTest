using System;
using System.Diagnostics;
using System.Linq;
using System.IO;

namespace SpeedTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select the number from the following list of possible tests:");

            var registryOfTypes = new RegisterOfTypes();

            foreach (var item in RegisterOfTypes.DictoraryOfTypes)
            {
                Console.WriteLine(item.Key);
            }

            var selection = Console.ReadLine();

            var dictonaryItemToActOn = RegisterOfTypes.DictoraryOfTypes.First(x => x.Key.Contains(selection));

            var sw = Stopwatch.StartNew();

            ulong count = 0;

            var timeInMillisecondsToRun = 300000; //300000;

            Console.Write("Run: 0 times");
            while(sw.Elapsed.TotalMilliseconds < timeInMillisecondsToRun)
            {
                dictonaryItemToActOn.Value.Act();
                count++;
                Console.Write("\rRun: {0} times | MS Left {1:N0}", count, timeInMillisecondsToRun - sw.Elapsed.TotalMilliseconds);
            }

            var utcTimeRan = DateTime.UtcNow;
            var date = utcTimeRan.ToLongDateString();
            var time = utcTimeRan.ToLongTimeString();

            var averageTime = timeInMillisecondsToRun / (float)count;

            var lineToWrite = string.Format("|{0}|{1}|{2}|{3:N0}|{4:N5}|", date, time, dictonaryItemToActOn.Key, count, averageTime);

            using(var file = new StreamWriter(@"C:\GitHub\SpeedTest\README.md", true))
            {
                file.WriteLine(lineToWrite);
            }
        }
    }
}
