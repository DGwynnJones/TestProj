
using System;

namespace TestProj.EFCodeFirst
{
    public class TestData
    {
        private Random _rnd = new Random();

        public static void DeleteAndRecreate(SchoolContext context)
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
                var stud = new Student() { FirstName = "Bill", LastName = "Student " + i };

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
