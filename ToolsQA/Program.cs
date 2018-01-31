using RelevantCodes.ExtentReports;

namespace ToolsQA
{
    class Program
    {
        static void Main(string[] args)
        {

            //var extent = new ExtentReports("E:\\Rezenkov\\Report.html", true);

            // creates a toggle for the given test, adds all log events under it    
            //var test = extent.StartTest("My First Test", "Sample description");

            // log(LogStatus, details)
            //test.Log(LogStatus.Info, "This step shows usage of log(logStatus, details)");

            // report with snapshot
            //string img = test.AddScreenCapture("E:\\Rezenkov\\IMG");
            //test.Log(LogStatus.Info, "Image example: " + img);

            // end test
            //extent.EndTest(test);

            // calling Flush writes everything to the log file
            //extent.Flush();
        }
    }
}
