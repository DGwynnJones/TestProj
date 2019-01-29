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
        [Test]
        public void Test_Data_Is_Created()
        {
            var testData = new TestData();

            using (var ctx = SchoolContextFactory.GetSchoolContext())
            {
                testData.DeleteAndRecreate(ctx);

                ctx.SaveChanges();
                var model = new SchoolModel(ctx);
                var allStudents = model.GetAllStudents();
                var allGrades = model.GetAllGrades();

                foreach (var item in allStudents)
                {
                    //Trace.WriteLine(item.ToString());
                    Assert.That(item.Address, Is.Not.Null);
                }

                foreach (var item in allGrades)
                {
                    Trace.WriteLine(item.ToString());
                    Assert.That(item.Students.Count, Is.GreaterThan(0));
                }
            }
        }

        [Test]
        public void DeleteTestData_Removes_All_Test_Data()
        {
            var testData = new TestData();

            using (var ctx = SchoolContextFactory.GetSchoolContext())
            {
                testData.DeleteAndRecreate(ctx);

                ctx.SaveChanges();

                testData.DeleteTestData(ctx);

                ctx.SaveChanges();

                var model = new SchoolModel(ctx);

                var allStudents = model.GetAllStudents();
                var allGrades = model.GetAllGrades();

                Assert.That(allStudents.Count, Is.EqualTo(0));
                Assert.That(allGrades.Count, Is.EqualTo(0));
            }
        }

        [Test]
        public void Cascade_Delete()
        {
            using (var ctx = SchoolContextFactory.GetSchoolContext())
            {
                var stud = new Student() { FirstName = "James" };
                var add = new StudentAddress() { Address1 = "address" };

                stud.Address = add;

                ctx.Students.Add(stud);

                ctx.SaveChanges();

                ctx.Students.Remove(stud);// student and its address will be removed from db

                ctx.SaveChanges();
            }

            var testData = new TestData();

            using (var ctx = SchoolContextFactory.GetSchoolContext())
            {
                testData.DeleteAndRecreate(ctx);

                ctx.SaveChanges();
            }
        }

        [Test]
        public void Read_Some_Data()
        {
            using (var ctx = SchoolContextFactory.GetSchoolContext())
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
        public void Read_Some_Data_From_Model()
        {
            var model = new SchoolModel(SchoolContextFactory.GetSchoolContext());

            var students = model.GetAllStudents();

            Assert.That(students.Count, Is.GreaterThan(0));

            foreach (var item in students)
            {
                Trace.WriteLine(item.ToString());
                Assert.That(item.Grade, Is.Not.Null);
            }
        }

        [Test]
        public void Eager_Loading_Test()
        {
            using (var ctx = SchoolContextFactory.GetSchoolContext())
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
