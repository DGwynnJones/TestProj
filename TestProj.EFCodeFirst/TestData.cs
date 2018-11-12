
using System;

namespace TestProj.EFCodeFirst
{
    public class TestData
    {
        private Random _rnd = new Random();

        public void DeleteAndRecreate(SchoolContext context)
        {
            //var students = context.Students;
            context.Students.RemoveRange(context.Students);
            context.Grades.RemoveRange(context.Grades);

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

            for (int i = 0; i < 10; i++)
            {
                var dob = new DateTime(1960 + _rnd.Next(0, 35), _rnd.Next(1, 12), _rnd.Next(1, 28));

                var stud = new Student()
                {
                    FirstName = "Bill",
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

                context.Students.Add(stud);
            }
        }
    }
}
