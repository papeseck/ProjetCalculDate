using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Authentification_API.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "FirstName"), MaxLength(80, ErrorMessage = "Taille maximale 80 ")]
        public string FirstName { get; set; }
        [Display(Name = "LastName"), MaxLength(80, ErrorMessage = "Taille maximale 80 ")]
        public string LastName { get; set; }
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "UserName"), MaxLength(80, ErrorMessage = "Taille maximale 80 ")]
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        public string Role { get; set; }
        public string Token { get; set; }
    }
}
