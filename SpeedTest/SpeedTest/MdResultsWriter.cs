using System.Collections.Generic;
using SnippetSpeed;
using SnippetSpeed.Interfaces;
using System.IO;

namespace SpeedTest
{
    public class MdResultsWriter : IResultWriter
    {
        public void Write(ICollection<SnippetSpeedTestResult> results)
        {
            var writeList = new List<string>
            {
                "|ClassName|TypeOfTest|Iterations|NanosecondsPerIteration|LengthOfTest(ms)|",
                "|---------|----------|---------:|----------------------:|---------------:|"
            };

            foreach (var result in results)
            {
                writeList.Add($"|{result.NameOfClass}|{result.TypeOfTest}|{result.Interations}|{result.AverageTimeOfIterationInNanoseconds}|{(int)result.LengthOfTest.TotalMilliseconds}|");
            }

            File.WriteAllLines(SnippetSpeedConsoleInterface.Settings.OutputPathAndFileName, writeList.ToArray());
        }
    }
}
