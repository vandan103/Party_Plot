using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ParttyPlotSystem.Models
{
    [Table("User")]
    public class User
    {
        [Display(Name = "User Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Uid { get; set; }

        [Display(Name = "User Name")]
        [Required(ErrorMessage = "{0} cannot be empty!")]
        public string Uname { get; set; }

        [Display(Name = "Phone Number")]
        [Required]
        [Phone]
        public String PNumber { get; set; }

        [Display(Name = "Email Id")]
        [Required]
        [EmailAddress]
        public String EmailId { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Role")]
        [Required(ErrorMessage = "{0} cannot be empty!")]
        public int Role { get; set; }

    }
}
