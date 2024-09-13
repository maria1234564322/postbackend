using System.ComponentModel.DataAnnotations;

namespace Web.Host.Model
{
    public class LoginIncomeModel
    {
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
