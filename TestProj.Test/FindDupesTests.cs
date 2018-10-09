using NUnit.Framework;
using System.IO;
using TestProj.Business.FindDupes;

namespace TestProj.Test
{
    [TestFixture]
    public class FindDupesTests : TestBase
    {
        [Test]
        public void Basic_()
        {
            var x = 0;
        }

        [Test]
        public void Find_Dupes()
        {
            var f1 = @"C:\Users\dgwynnjones\source\repos\SA.RMS\SA.RMS";
            var f2 = @"C:\Users\dgwynnjones\source\repos\SA.RMS\Referenced";

            var obj = new FindDupes(f1, f2, "*.cs");

            //foreach (var item in obj.DuplicateFiles)
            //{
            //    Trace.WriteLine(item.ToString());
            //}

        }

        [Test]
        public void Find_Dupes_2()
        {
            var dir1 = new DirectoryInfo( TestFolder( @".\FindDupes\Files1"));

            var f1 = @"C:\Users\dgwynnjones\source\repos\SA.RMS\SA.RMS";
            var f2 = @"C:\Users\dgwynnjones\source\repos\SA.RMS\Referenced";

            var obj = new FindDupes(f1, f2, "*.cs");

            //foreach (var item in obj.DuplicateFiles)
            //{
            //    Trace.WriteLine(item.ToString());
            //}

        }

    }
}
