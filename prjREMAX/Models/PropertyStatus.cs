using System.ComponentModel.DataAnnotations;

namespace prjREMAX.Models
{
    public class PropertyStatus
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}