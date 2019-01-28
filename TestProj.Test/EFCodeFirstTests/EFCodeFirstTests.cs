using NUnit.Framework;
using SA.UnitTestingHelper;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using TestProj.EFCodeFirst;

namespace TestProj.Test.EFCodeFirstTests
{
    [TestFixture]
    public class EFCodeFirstTests : TestBase
    {
        private string _dbName = "TestProj.EFCodeFirst.SchoolContext";

        [Test]
        public void Basic_()
        {
            var testData = new TestData();

            using (var ctx = new SchoolContext(_dbName))
            {
                testData.DeleteAndRecreate(ctx);

                ctx.SaveChanges();
            }
        }

        [Test]
        public void Read_Some_Data()
        {
            using (var ctx = new SchoolContext(_dbName))
            {
                var students = ctx.Students.Include(g => g.Grade).ToList();

                Assert.That(students.Count, Is.GreaterThan(0));

                foreach (var item in students)
                {
                    Trace.WriteLine(item.ToString());
                    Assert.That(item.Grade, Is.Not.Null);
                }
            }
        }

        [Test]
        public void Eager_Loading_Test()
        {
            using (var ctx = new SchoolContext(_dbName))
            {
                var students = ctx.Students.Include(x => x.Grade).ToList();

                foreach (var item in students)
                {
                    Trace.WriteLine(item.ToString());
                    Trace.WriteLine(item.Grade.ToString());

                    Assert.That(item.Grade, Is.Not.Null);
                }

                Assert.That(students.Count, Is.GreaterThan(0));
            }
        }
    }
}
