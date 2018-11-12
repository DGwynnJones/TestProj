using NUnit.Framework;
using System.Diagnostics;
using System.Linq;
using TestProj.EFCodeFirst;

namespace TestProj.Test
{
    [TestFixture]
    public class EFCodeFirstTests
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
                var students = ctx.Students.ToList();

                foreach (var item in students)
                {
                    //Trace.WriteLine(string.Format("{0} {1} {2}", item.FirstName, item.LastName, item.Grade.GradeName));
                    //Trace.WriteLine(string.Format("{0} {1}", item.FirstName, item.LastName));
                    Trace.WriteLine(item.ToString());
                }

                Assert.That(students.Count, Is.GreaterThan(0));
            }
        }
    }
}
