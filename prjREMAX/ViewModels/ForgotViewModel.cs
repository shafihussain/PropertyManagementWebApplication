using System.ComponentModel.DataAnnotations;

namespace prjREMAX.ViewModels
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}