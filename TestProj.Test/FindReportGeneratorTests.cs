using NUnit.Framework;
using System.Diagnostics;

namespace TestProj.Test
{
    [TestFixture]
    public class FindReportGeneratorTests
    {
        [Test]
        public void Basic_()
        {
            Trace.WriteLine(">> " + Coverageinfo.GetReportGenerator());
        }
    }
}
