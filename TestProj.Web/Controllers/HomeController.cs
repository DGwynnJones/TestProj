using System.Linq;
using System.Web.Mvc;
using TestProj.EFCodeFirst;

namespace TestProj.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Info()
        {
            ViewBag.Message = "Your application information page.";

            var context = new SchoolContext("TestDBEntities"); // "TestProj.EFCodeFirst.SchoolContext");



            var x = context.Students
                            .Where(b => b.FirstName == "Bill")
                            .FirstOrDefault();

            var employees = context.Students.ToList();

            return View(employees);

        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}