using System.Collections.Generic;
using prjREMAX.Models;

namespace prjREMAX.ViewModels
{
    public class PropertyFormViewModel
    {
        //TextBoxes
        public string PropertyName { get; set; }
        public string Price { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Description { get; set; }
        public string Year { get; set; }
        public string CivicNumber { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public string Zipcode { get; set; }
        public string Rooms { get; set; }
        public string Bathrooms { get; set; }
        public string Size { get; set; }
        
        //DropDown List
        public int Type { get; set; }
        public int Status { get; set; }
        public IEnumerable<PropertyStatus> Statuses { get; set; }
        public IEnumerable<PropertyType> Types { get; set; }
    }
}