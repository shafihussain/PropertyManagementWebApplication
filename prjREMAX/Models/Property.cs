using System;
using System.ComponentModel.DataAnnotations;

namespace prjREMAX.Models
{
    public class Property
    {
        public int PropertyId { get; set; }
        [Required]
        public ApplicationUser Manager { get; set; }
        [Required]
        public string ManagerId { get; set; }
        [Required]
        [StringLength(255)]
        public string PropertyName { get; set; }
        [Required]
        [StringLength(255)]
        public Address Address { get; set; }
        [Required]
        public string AddressId { get; set; }
        //The DateTime the Property was Listed
        public DateTime DateTime { get; set; }
        //The year the property was buit on
        public int Year { get; set; }
        [Required]
        [StringLength(255)]
        public string Description { get; set; }
        [Required]
        public int Rooms { get; set; }
        [Required]
        public int Bathrooms { get; set; }
        [Required]
        public int Size { get; set; }
        [Required]
        public PropertyStatus Status { get; set; }
        [Required]
        public byte StatusId { get; set; }
        [Required]
        public PropertyType Type { get; set; }
        [Required]
        public byte TypeId { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}