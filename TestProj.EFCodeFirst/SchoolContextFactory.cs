namespace TestProj.EFCodeFirst
{
    public class SchoolContextFactory
    {
        public static SchoolContext GetSchoolContext()
        {
            return new SchoolContext();
        }
    }
}
