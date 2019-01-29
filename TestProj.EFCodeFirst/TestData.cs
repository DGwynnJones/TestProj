
using System;
using TestProj.EFCodeFirst.EFPocoClasses;

namespace TestProj.EFCodeFirst
{
    public class TestData
    {
        public static void DeleteTestData(SchoolContext context)
        {
            context.StudentAddresses.RemoveRange(context.StudentAddresses);
            context.StudentAddresses.RemoveRange(context.StudentAddresses);
            context.Students.RemoveRange(context.Students);
            context.Grades.RemoveRange(context.Grades);
            context.SaveChanges();
        }

        public static void DeleteAndRecreate(SchoolContext context)
        {
            var _rnd = new Random();

            DeleteTestData(context);

            var gradeCredit = new Grade()
            {
                GradeName = "Credit",
                Section = "Art",
                GradeValue = 4
            };

            var gradePass = new Grade()
            {
                GradeName = "Pass",
                Section = "Art",
                GradeValue = 3
            };

            for (int i = 0; i < 4; i++)
            {
                var dob = new DateTime(1960 + _rnd.Next(0, 35), _rnd.Next(1, 12), _rnd.Next(1, 28));

                var stud = new Student()
                {
                    FirstName = "Bill " + i,
                    LastName = "Student " + i,
                    DateOfBirth = dob,
                    Height = _rnd.Next(140, 220),
                    Weight = _rnd.Next(50, 120)
                };

                if (i % 2 == 0)
                {
                    stud.Grade = gradePass;
                }
                else
                {
                    stud.Grade = gradeCredit;
                }

                var addr = new StudentAddress()
                {
                    Address1 = "addr 1 " + stud.FirstName,
                    Address2 = "addr 2",
                    City = "Wanaaring",
                    State = "NSW",
                    Country = "Straya",
                    Student = stud
                };
                stud.Address = addr;

                //context.st

                context.Students.Add(stud);

                context.SaveChanges();
            }
        }
    }
}
