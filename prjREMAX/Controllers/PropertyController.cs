using System.Linq;
using System.Web.Mvc;
using prjREMAX.Models;
using prjREMAX.ViewModels;

namespace prjREMAX.Controllers
{
    public class PropertyController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PropertyController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Property
        public ActionResult Create()
        {
            var viewModel = new PropertyFormViewModel
            {
                Statuses = _context.Statuses.ToList(),
                Types = _context.Types.ToList()
            };
            return View(viewModel);
        }
    }
}