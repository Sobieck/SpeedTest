using System;
using System.Diagnostics;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Concurrent;

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
                NonBlockingConsole.Write(new NonBlockingConsoleInput(count, sw.Elapsed.TotalMilliseconds, timeInMillisecondsToRun));
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

        public class NonBlockingConsoleInput
        {
            public NonBlockingConsoleInput(ulong count, double millisecondsElapsed, int timeInMillisecondsToRun)
            {
                Count = count;
                MillisecondsElapsed = millisecondsElapsed;
                TimeInMillisecondsToRun = timeInMillisecondsToRun;
             }

            public ulong Count { get; private set; }
            public double MillisecondsElapsed { get; private set; }
            public int TimeInMillisecondsToRun { get; private set; }
        }

        public static class NonBlockingConsole
        {
            private static NonBlockingConsoleInput ItemToWrite { get; set; }

            static NonBlockingConsole()
            {
                Task.Run(() =>
                {
                    while (true)
                    {
                        var output = string.Format("\rRun: {0} times | MS Left {1:N0}", ItemToWrite.Count, ItemToWrite.TimeInMillisecondsToRun - ItemToWrite.MillisecondsElapsed);
                        Console.Out.WriteAsync(output);
                    }
                });
            }

            public static void Write(NonBlockingConsoleInput itemToWrite)
            {
                ItemToWrite = itemToWrite;
            }
        }
    }
}
