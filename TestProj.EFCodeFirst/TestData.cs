namespace TestProj.EFCodeFirst
{
    public class TestData
    {
        public static void DeleteAndRecreate(SchoolContext context)
        {
            //var students = context.Students;
            context.Students.RemoveRange(context.Students);
            context.Grades.RemoveRange(context.Grades);

            var gradeCredit = new Grade() { GradeName = "Credit", Section = "Art" };

            for (int i = 0; i < 10; i++)
            {
                var stud = new Student() { FirstName = "Bill", LastName = "Student " + i };
                stud.Grade = gradeCredit;

                context.Students.Add(stud);
            }
        }
    }
}
