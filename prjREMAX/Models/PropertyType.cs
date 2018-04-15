using System.ComponentModel.DataAnnotations;

namespace prjREMAX.Models
{
    public class PropertyType
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}