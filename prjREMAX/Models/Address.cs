namespace prjREMAX.Models
{
    public class Address
    {
        public int Id { get; set; }
        public int CivicNumber { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Province { get; set; }
    }
}