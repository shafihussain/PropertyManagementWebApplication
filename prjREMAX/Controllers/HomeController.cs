using System;
using System.Linq;
using System.Web.Mvc;
using prjREMAX.Models;
using System.Data.Entity;

namespace prjREMAX.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();  
        }

        //Get all the properties currently set in the database and display their respected information
        public ActionResult Index()
        {
            var properties = _context.Properties
                .Include(p => p.Manager)
                .Where(g => g.DateTime > DateTime.Now);
            return View(properties);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}