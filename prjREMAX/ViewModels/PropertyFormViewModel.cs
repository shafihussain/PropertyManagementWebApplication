 using System.Collections.Generic;
using prjREMAX.Models;

namespace prjREMAX.ViewModels
{
    public class PropertyFormViewModel
    {
        //TextBoxes
        public string PropertyName { get; set; }
        public decimal Price { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public string CivicNumber { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Zipcode { get; set; }
        public int Rooms { get; set; }
        public int Bathrooms { get; set; }
        public int Size { get; set; }
        public Address Address { get; set; }
        //DropDown List
        public byte Type { get; set; }
        public byte Status { get; set; }
        public IEnumerable<PropertyStatus> Statuses { get; set; }
        public IEnumerable<PropertyType> Types { get; set; }
    }
}