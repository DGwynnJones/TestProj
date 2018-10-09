using NUnit.Framework;
using System.Diagnostics;
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
            var dir1 = TestFolder(@".\FindDupes\Files1");
            var dir2 = TestFolder(@".\FindDupes\Files2");

            var obj = new FindDupes(dir1, dir2, "*.*");

            Trace.WriteLine(obj.ToString());

            Trace.WriteLine("\n\nSetA:");
            foreach (var item in obj.SetA)
            {
                Trace.WriteLine(item);
            }

            Trace.WriteLine("\n\nSetB:");
            foreach (var item in obj.SetB)
            {
                Trace.WriteLine(item);
            }

            Trace.WriteLine("\n\nDuplicateFiles:");
            foreach (var item in obj.DuplicateFiles)
            {
                Trace.WriteLine(item);
            }


            //Trace.WriteLine("ALL:");
            //foreach (var item in obj.DuplicateFiles)
            //{
            //    Trace.WriteLine(item.ToString());
            //}

        }

    }
}
