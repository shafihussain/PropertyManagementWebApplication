 using System;
using System.Collections.Generic;
 using System.ComponentModel.DataAnnotations;
 using System.ComponentModel.DataAnnotations.Schema;
 using System.Linq;
using System.Web;

namespace prjREMAX.Models
{
    public class Appointment
    {
        public Property Property { get; set; }
        public ApplicationUser PotentialBuyer { get; set; }

        [Key]//Data Annotation
        [Column(Order = 1)]//Composite Key Order Specification
        public int PropertyId { get; set; }

        [Key]
        [Column(Order = 2)]
        public string AppointmentId { get; set; }
    }
}