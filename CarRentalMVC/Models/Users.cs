using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRentalMVC.Models
{
    public class Users
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Imię")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Nazwisko")]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Rok otrzymana prawa jazdy")]
        public int DrivingLicenseYears { get; set; }

        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Adres e-mail")]
        public string Email { get; set; } = string.Empty;
        [Required]       
        [Display(Name = "Hasło")]
        public string Password { get; set; } = string.Empty;
    }
}
