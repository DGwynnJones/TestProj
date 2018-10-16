using NUnit.Framework;
using System;
using System.Diagnostics;
using System.IO;
using TestProj.Business.FindDupes;

namespace TestProj.Test
{
    [TestFixture]
    public class FindDupesTests : TestBase
    {

        [Test]
        public void Find_Dupes()
        {
            var f1 = @"C:\Users\dgwynnjones\source\repos\SA.RMS\SA.RMS";
            var f2 = @"C:\Users\dgwynnjones\source\repos\SA.RMS\Referenced";

            var obj = new FindDupes(f1, f2, "*.cs");

            Trace.WriteLine(obj.ToString());

            foreach (var item in obj.DuplicateFiles)
            {
                Trace.WriteLine(item.ToString());
            }

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

        [Test]
        public void Find_Dupes_3()
        {
            CreateTestFiles();

            //var obj = new FindDupes(dir1, dir2, "*.*");

        }

            private void CreateTestFiles()
        {
            const string DUPLICATE_CONTENT = "Duplicate content.";

            var root = TestFolder("Test_" + DateTime.Now.Ticks);
            var folder1 = new DirectoryInfo(Path.Combine(root, "folder1"));
            var folder2 = new DirectoryInfo(Path.Combine(root, "folder2"));

            folder1.Create();
            folder2.Create();

            File.WriteAllText(folder1.GetFilename("file1.txt"), DUPLICATE_CONTENT);
            File.WriteAllText(folder1.GetFilename("file2.txt"), "Unique content: " + DateTime.Now.Ticks);
            File.WriteAllText(folder1.GetFilename("file3.txt"), DUPLICATE_CONTENT);

            File.WriteAllText(folder2.GetFilename("file1.txt"), DUPLICATE_CONTENT);
            File.WriteAllText(folder2.GetFilename("file2.txt"), "Unique content: " + DateTime.Now.Ticks);
            File.WriteAllText(folder2.GetFilename("file3.txt"), DUPLICATE_CONTENT);

        }

    }
}
