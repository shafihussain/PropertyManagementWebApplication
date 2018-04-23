using System;
using System.Linq;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
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
        [Authorize]
        //public ActionResult Mine()
        //{
        //    var managerId = User.Identity.GetUserId();
        //    var properties = _context.Properties
        //        .Where(p => p.ManagerId == managerId && p.DateTime > DateTime.Now)
        //        .ToList();
        //}

        [Authorize]
        public ActionResult Create() 
        {
            var viewModel = new PropertyFormViewModel
            {
                Statuses = _context.Statuses.ToList(),
                Types = _context.Types.ToList()
            };
            return View(viewModel);
        }
        [Authorize]//only authenticated users can call this method
        [HttpPost]//action to be called only by HTTPPOST method
        public ActionResult Create(PropertyFormViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Types = _context.Types.ToList();
                viewModel.Statuses = _context.Statuses.ToList();
                return View("Create", viewModel);
            }

            #region Refactored Code
            ////convert the PropertyViewModel to a property object, add it to the _context and save the changes.
            //var manager = _context.Users.Single(u => u.Id == managerId);
            //var status = _context.Statuses.Single(s => s.Id == viewModel.Status);
            //var type = _context.Types.Single(t => t.Id == viewModel.Type);
            #endregion

            var property = new Property
            {
                ManagerId = User.Identity.GetUserId(),
                DateTime = viewModel.GetDateTime(),
                StatusId = viewModel.Status,
                TypeId = viewModel.Type,
                PropertyName = viewModel.PropertyName,
                Year = viewModel.Year,
                Description = viewModel.Description,
                Rooms = viewModel.Rooms,
                Bathrooms = viewModel.Bathrooms,
                Size = viewModel.Size,
                Price = viewModel.Price
                
                //Need to add Address               
            };
            _context.Properties.Add(property);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}