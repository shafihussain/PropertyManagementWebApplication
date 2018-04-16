 using System;
 using System.Collections.Generic;
 using System.ComponentModel.DataAnnotations;
 using prjREMAX.Models;

namespace prjREMAX.ViewModels
{
    public class PropertyFormViewModel
    {
        //TextBoxes
        [Required]
        public string PropertyName { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string Date { get; set; }

        [Required]
        public string Time { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int Year { get; set; }

        #region Property Address
        [Required]
        public string CivicNumber { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Province { get; set; }

        [Required]
        public string Zipcode { get; set; }
        #endregion

        [Required]
        public int Rooms { get; set; }

        [Required]
        public int Bathrooms { get; set; }

        [Required]
        public int Size { get; set; }

        [Required]
        public Address Address { get; set; }

        //DropDown List
        [Required]
        public byte Type { get; set; }

        [Required]
        public byte Status { get; set; }


        public IEnumerable<PropertyStatus> Statuses { get; set; }
        public IEnumerable<PropertyType> Types { get; set; }

        public DateTime GetDateTime()
        {
           return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}