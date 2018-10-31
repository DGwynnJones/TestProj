using System;

namespace TestProj.EFCodeFirst
{
    public class Application
    {
        public static void Main()
        {
            // var dbName = "TestProj.EFCodeFirst_" + DateTime.Now.Ticks;
            var dbName = "TestProj.EFCodeFirst";

            using (var ctx = new SchoolContext(dbName))
            {
                var stud = new Student() { StudentName = "Bill" };

                stud.Grade = new Grade() { GradeName = "Credit", Section = "Art" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}
