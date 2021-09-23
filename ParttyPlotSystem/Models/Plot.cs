using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ParttyPlotSystem.Models
{
    [Table("Plot")]
    public class Plot
    {

        [Display(Name = "Plot Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PId { get; set; }

        [Display(Name = "Plot Name")]
        [Required(ErrorMessage = "{0} cannot be empty!")]
        public String Name { get; set; }

        [Display(Name = "Address")]
        [Required]
        public String Address { get; set; }

        [Required]
        [Display(Name = "Status")]
        public String Status { get; set; }

        [Required]
        [Display(Name = "Payment Price")]
        public int PaymentPrice { get; set; }

        [Required]
        [Display(Name = "Image")]
        public String Image { get; set; }


        ////foreignKey 
        //#region Navigation Properties to the Customer MOdel

        //[Display(Name = "User")]
        //[Required]
        //[Column("Uid")]
        //[ForeignKey(nameof(Plot.User))]
        //public int CId { get; set; }

        //public User User { get; set; }

        //#endregion



        //#region Navigatio Properties to the Screen Model

        //public ICollection<Screen> Screens { get; set; }


        //#endregion

    }
}
