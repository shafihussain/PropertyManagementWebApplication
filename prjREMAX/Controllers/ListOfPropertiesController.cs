using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace prjREMAX.Controllers
{
    public class ListOfPropertiesController : Controller
    {
        // GET: ListOfProperties
        public ActionResult properties()
        {
            return View();
        }
    }
}