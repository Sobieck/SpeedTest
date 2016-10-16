using SnippetSpeed;

namespace SpeedTest
{
    public static class Program
    {
        static void Main(string[] args)
        {
            //SnippetSpeedConsoleInterface.Settings.LengthOfOneTestRound = new System.TimeSpan(0, 0, 10); // optional
            SnippetSpeedConsoleInterface.Settings.OutputPathAndFileName = "README.md"; // optional
            SnippetSpeedConsoleInterface.ResultWriter = new MdResultsWriter(); //optional
            

            SnippetSpeedConsoleInterface.Run();
        }
    }
}
