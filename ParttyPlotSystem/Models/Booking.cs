using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ParttyPlotSystem.Models
{
    [Table("Booking")]

    public class Booking
    {
        [Display(Name = "Booking Id")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BId { get; set; }

        [Display(Name = "Booking Type")]
        [Required(ErrorMessage = "{0} cannot be empty!")]
        public String Type { get; set; }

        //[Display(Name = "Plot Name")]
        //[Required(ErrorMessage = "{0} cannot be empty!")]
        //public String PName { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "{0} cannot be empty!")]
        public String Desc { get; set; }

        [Display(Name = "Booking Date")]
        [Required(ErrorMessage = "{0} cannot be empty!")]
        public DateTime BDate { get; set; }

        [Required]
        [Display(Name = "Status")]
        public String Status { get; set; }

        //foreignKey 
        #region Navigation Properties to the Customer MOdel

        [Display(Name = "Plot Name")]
        [Required]
        [Column("Uid")]
        [ForeignKey(nameof(Booking.Plot))]
        public int PId { get; set; }
    
        public Plot Plot{ get; set; }

        #endregion


    }
}
