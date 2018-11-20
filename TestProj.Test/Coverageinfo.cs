using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace TestProj.Test
{
    public class Coverageinfo
    {
        public static string GetReportGenerator()
        {
            var localDir = new FileInfo(Assembly.GetExecutingAssembly().Location).Directory.Parent.Parent.Parent;

            var rgExe = localDir.GetFiles("ReportGenerator.exe", SearchOption.AllDirectories);

            var result = "";

            if (rgExe.Length == 1)
            {
                result = rgExe[0].FullName;
            }

            Trace.WriteLine(rgExe[0].FullName);

            return result;
        }
    }
}
