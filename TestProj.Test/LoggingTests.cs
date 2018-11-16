using NUnit.Framework;
using SA.UnitTestingHelper;
using System;
using System.IO;

namespace TestProj.Test
{
    [TestFixture]
    public class LoggingTests : TestBase
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        [Test]
        public void Basic_()
        {
            var message = "Hello world at " + DateTime.Now.ToLongTimeString();

            log.Info(message);

            var logFile = new FileInfo(TestFolder("myapp.log"));

            Assert.That(logFile.Exists);

            // Seems to need  <lockingModel type="log4net.Appender.FileAppender+MinimalLock" />
            // to avoid file locking conflict
            var logcontents = File.ReadAllText(logFile.FullName);

            Assert.That(logcontents.Contains(message));
        }
    }
}
