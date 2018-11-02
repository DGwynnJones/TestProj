
namespace TestProj.EFCodeFirst
{
    public class Application
    {
        public static void Main()
        {
            var dbName = "TestProj.EFCodeFirst.SchoolContext";

            using (var ctx = new SchoolContext(dbName))
            {
                TestData.DeleteAndRecreate(ctx);

                ctx.SaveChanges();
            }
        }
    }
}
