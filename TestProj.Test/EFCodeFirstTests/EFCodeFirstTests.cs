using NUnit.Framework;
using System.Diagnostics;
using System.Linq;
using TestProj.EFCodeFirst;

namespace TestProj.Test
{
    [TestFixture]
    public class EFCodeFirstTests
    {
        [Test]
        public void Basic_()
        {
            var dbName = "TestProj.EFCodeFirst.SchoolContext";

            using (var ctx = new SchoolContext(dbName))
            {
                TestData.DeleteAndRecreate(ctx);

                ctx.SaveChanges();
            }
        }

        [Test]
        public void Read_Some_Data()
        {
            var dbName = "TestProj.EFCodeFirst.SchoolContext";

            using (var ctx = new SchoolContext(dbName))
            {
                var students = ctx.Students.ToList();

                foreach (var item in students)
                {
                    //Trace.WriteLine(string.Format("{0} {1} {2}", item.FirstName, item.LastName, item.Grade.GradeName));
                    Trace.WriteLine(string.Format("{0} {1}", item.FirstName, item.LastName));
                }

                Assert.That(students.Count, Is.GreaterThan(0));
            }
        }
    }
}
