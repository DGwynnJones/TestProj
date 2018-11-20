using System.IO;

namespace TestProj.Test
{
    public class Coverageinfo
    {
        public static string GetReportGenerator()
        {
            return GetReportGenerator(null);
        }

        public static string GetReportGenerator(string path)
        {
            var result = path;

            var localDir = new FileInfo(path).Directory.Parent.Parent.Parent;
            var rgExe = localDir.GetFiles("ReportGenerator.exe", SearchOption.AllDirectories);

            if (rgExe.Length == 1)
            {
                result = rgExe[0].FullName;
                //Trace.WriteLine(rgExe[0].FullName);
            }
            else
            {
                result = "RG not found in path " + path;
            }

            return result;
        }

        //public static string GetReportGenerator(string path)
        //{
        //    var exeDir = new FileInfo(Assembly.GetExecutingAssembly().Location).Directory.FullName;
        //    var localDir = new FileInfo(Assembly.GetExecutingAssembly().Location).Directory.Parent.Parent.Parent;

        //    Trace.WriteLine(">> " + localDir.FullName);

        //    var rgExe = localDir.GetFiles("ReportGenerator.exe", SearchOption.AllDirectories);

        //    var result = "";

        //    if (rgExe.Length == 1)
        //    {
        //        result = rgExe[0].FullName;
        //        //Trace.WriteLine(rgExe[0].FullName);
        //    }
        //    else
        //    {
        //        result = exeDir + " !!!!!!!!!!!!!!!!";
        //    }

        //    return result;
        //}
    }
}
