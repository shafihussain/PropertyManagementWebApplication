using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using prjREMAX.Models;

namespace prjREMAX.Controllers
{
    [Authorize]
    public class AppointmentsController : ApiController
    {
        private ApplicationDbContext _context;

        public AppointmentsController()
        {
            _context = new ApplicationDbContext();
        }
        [HttpPost]//Only call it using HTTPPOST 
        //create action called attend
        public IHttpActionResult Appointment([FromBody] int propertyId)
        {
            //Handle duplication exception error
            //var userId = User.Identity.GetUserId();
            //var exists = _context.Appointments.Any(a => a.AppointmentId == UserId && a.Property == propertyId);

            var appointment = new Appointment
            {
                PropertyId = propertyId,
                AppointmentId = User.Identity.GetUserId()
            };
            _context.Appointments.Add(appointment);
            _context.SaveChanges();

            return Ok();
        }
    }
}
