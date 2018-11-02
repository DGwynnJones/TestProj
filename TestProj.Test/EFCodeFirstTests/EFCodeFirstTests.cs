using NUnit.Framework;
using System.Diagnostics;
using TestProj.EFCodeFirst;

namespace TestProj.Test
{
    [TestFixture]
    public class EFCodeFirstTests
    {
        [Test]
        public void Basic_()
        {
            Application.Main();
        }

        [Test]
        public void Read_Sonme_Data()
        {
            var dbName = "TestProj.EFCodeFirst.SchoolContext";

            using (var ctx = new SchoolContext(dbName))
            {
                foreach (var item in ctx.Students)
                {
                    Trace.WriteLine(item.FirstName);
                }
            }
        }
    }
}
