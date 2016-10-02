using System;
using System.Diagnostics;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

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

            ulong count = 0;

            var timeInMillisecondsToRun = 300000; //300000;

            NonBlockingConsole.TimeInMillisecondsToRun = timeInMillisecondsToRun;

            var sw = Stopwatch.StartNew();

            while (sw.Elapsed.TotalMilliseconds < timeInMillisecondsToRun)
            {
                dictonaryItemToActOn.Value.Act();
                count++;
                NonBlockingConsole.Iterations = count;
                NonBlockingConsole.MillisecondsElapsed = sw.Elapsed.TotalMilliseconds;
            }

            var utcTimeRan = DateTime.UtcNow;
            var date = utcTimeRan.ToLongDateString();
            var time = utcTimeRan.ToLongTimeString();

            var averageTime = timeInMillisecondsToRun / (float)count;

            var lineToWrite = string.Format("|{0}|{1}|{2}|{3:N0}|{4:N5}|", date, time, dictonaryItemToActOn.Key, count, averageTime);

            using (var file = new StreamWriter(@"C:\GitHub\SpeedTest\README.md", true))
            {
                file.WriteLine(lineToWrite);
            }
        }
    }
}
