
namespace TestProj.EFCodeFirst
{
    public class Application
    {
        public static void Main()
        {
            // var dbName = "TestProj.EFCodeFirst_" + DateTime.Now.Ticks;
            var dbName = "TestProj.EFCodeFirst.SchoolContext";

            //dbName = SchoolContext

            using (var ctx = new SchoolContext(dbName))
            {
                var gradeCredit = new Grade() { GradeName = "Credit", Section = "Art" };

                for (int i = 0; i < 10; i++)
                {
                    var stud = new Student() { StudentName = "Bill-" + i };
                    stud.Grade = gradeCredit;
                    ctx.Students.Add(stud);
                }

                ctx.SaveChanges();
            }
        }
    }
}
