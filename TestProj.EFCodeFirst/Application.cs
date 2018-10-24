namespace TestProj.EFCodeFirst
{
    public class Application
    {
        public static void Main()
        {
            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Bill" };

                stud.Grade = new Grade() { GradeName = "Credit", Section = "Art" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}
