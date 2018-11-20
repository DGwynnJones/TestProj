using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace TestProj.Test
{
    [TestFixture]
    public class FindReportGeneratorTests
    {
        [Test]
        public void Basic_()
        {

            Trace.WriteLine(">> "+ Coverageinfo.GetReportGenerator() );

        }

    }
}
