using SnippetSpeed;

namespace SpeedTest
{
    public static class Program
    {
        static void Main(string[] args)
        {
            SnippetSpeedConsoleInterface.Settings.LengthOfOneTestRound = new System.TimeSpan(0, 0, 10);
            SnippetSpeedConsoleInterface.Settings.OutputPathAndFileName = "README.md";
            SnippetSpeedConsoleInterface.ResultWriter = new MdResultsWriter();

            SnippetSpeedConsoleInterface.Run();
        }
    }
}
