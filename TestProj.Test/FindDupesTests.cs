using NUnit.Framework;
using TestProj.Business.FindDupes;

namespace TestProj.Test
{
    [TestFixture]
    public class FindDupesTests
    {
        [Test]
        public void Basic_()
        {
            var f1 = @"C:\Users\dgwynnjones\source\repos\SA.RMS\SA.RMS";
            var f2 = @"C:\Users\dgwynnjones\source\repos\SA.RMS\Referenced";

            var obj = new FindDupes(f1, f2, "*.cs");


        }

    }
}
