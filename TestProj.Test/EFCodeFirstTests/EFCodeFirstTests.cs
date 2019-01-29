using NUnit.Framework;
using SA.UnitTestingHelper;
using SA.Utilities;
using System.Data.Entity.Validation;
using System.Diagnostics;
using TestProj.EFCodeFirst;
using TestProj.EFCodeFirst.EFPocoClasses;

namespace TestProj.Test.EFCodeFirstTests
{
    [TestFixture]
    public class EFCodeFirstTests : TestBase
    {
        [Test]
        public void Test_Data_Is_Created()
        {
            using (var ctx = SchoolContextFactory.GetSchoolContext())
            {
                TestData.DeleteAndRecreate(ctx);

                ctx.SaveChanges();
                var model = new SchoolModel(ctx);
                var allStudents = model.GetAllStudents();
                var allGrades = model.GetAllGrades();

                foreach (var item in allStudents)
                {
                    //Trace.WriteLine(item.ToString());
                    Assert.That(item.Grade, Is.Not.Null);
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
        public void Read_Some_Data_From_Model()
        {
            var model = new SchoolModel(SchoolContextFactory.GetSchoolContext());

            TestData.DeleteAndRecreate(model.Context);

            var students = model.GetAllStudents();

            Assert.That(students.Count, Is.GreaterThan(0));

            foreach (var item in students)
            {
                Trace.WriteLine(item.ToString());
                Assert.That(item.Address, Is.Not.Null);
            }
        }

        [Test]
        public void Read_Some_Data_From_Model_2()
        {
            using (var ctx = SchoolContextFactory.GetSchoolContext())
            {
                var model = new SchoolModel(ctx);

                TestData.DeleteAndRecreate(ctx);

                var students = model.GetAllStudents();

                Assert.That(students.Count, Is.GreaterThan(0));

                foreach (var item in students)
                {
                    Trace.WriteLine(item.ToString());
                    Assert.That(item.Grade, Is.Not.Null);
                }
            }
        }

        [Test]
        public void Cascade_Delete_One_to_Many()
        {
            using (var ctx = SchoolContextFactory.GetSchoolContext())
            {
                TestData.DeleteTestData(ctx);

                var grade = new Grade() { GradeName = "Credit", GradeValue = 2, Section = "Senior" };

                // NB can't 'share' address between both students..
                var addr1 = new StudentAddress() { Address1 = "address 1" };
                var addr2 = new StudentAddress() { Address1 = "address 1" };

                var student1 = new Student()
                {
                    FirstName = "James",
                    LastName = "Joyce",
                    Grade = grade,
                    Address = addr1
                };

                var student2 = new Student()
                {
                    FirstName = "Gustave",
                    LastName = "Flaubert",
                    Grade = grade,
                    Address = addr2
                };

                var standard1 = new Standard() { StandardName = "Standard 1" };

                student1.Standard = standard1;
                student2.Standard = standard1;

                ctx.Students.Add(student1);
                ctx.Students.Add(student2);

                try
                {
                    //inserts students and standard1 into db
                    ctx.SaveChanges();

                    //deletes standard1 from db and also set standard_StandardId FK column in Students table to null for
                    // all the students that reference standard1.
                    ctx.Standards.Remove(standard1);

                    ctx.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    Trace.WriteLine("");
                    Trace.WriteLine(EntityUtilities.GetErrors(ex));
                    throw ex;
                }

                var model = new SchoolModel(ctx);

                var st = model.GetAllStudents();

                foreach (var item in st)
                {
                    Trace.WriteLine(item.ToString());
                }
            }
        }

        [Test]
        public void DeleteTestData_Removes_All_Test_Data()
        {
            using (var ctx = SchoolContextFactory.GetSchoolContext())
            {
                TestData.DeleteAndRecreate(ctx);

                ctx.SaveChanges();

                TestData.DeleteTestData(ctx);

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
            try
            {
                using (var ctx = SchoolContextFactory.GetSchoolContext())
                {
                    TestData.DeleteTestData(ctx);
                    ctx.SaveChanges();

                    var grade = new Grade() { GradeName = "Credit", GradeValue = 2, Section = "Senior" };
                    var stud = new Student() { FirstName = "James", LastName = "Joyce", Grade = grade };
                    var add = new StudentAddress() { Address1 = "address" };

                    stud.Address = add;

                    ctx.Students.Add(stud);

                    ctx.SaveChanges();

                    ctx.Students.Remove(stud);

                    ctx.SaveChanges();
                }
            }
            catch (DbEntityValidationException ex)
            {
                Trace.WriteLine("");
                Trace.WriteLine(EntityUtilities.GetErrors(ex));
                throw ex;
            }
        }
    }
}
