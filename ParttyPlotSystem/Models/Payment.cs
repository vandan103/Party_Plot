using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ParttyPlotSystem.Models
{
    [Table("Payment")]
    public class Payment
    {
        [Display(Name = "Payment ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(ErrorMessage = "{0} cannot be empty!")]
        public int PaymentId { get; set; }

        //foreignKey 
        #region Navigation Properties to the Customer MOdel

        [Display(Name = "Plot Name")]
        [Required]
        [Column("Uid")]
        [ForeignKey(nameof(Payment.Plot))]
        public int PId { get; set; }

        public Plot Plot { get; set; }

        #endregion

        [Display(Name = "PaymentPrice")]
        [Required(ErrorMessage = "{0} cannot be empty!")]
        public int Price { get; set; }

        [Display(Name = "Payment Status")]
        [Required(ErrorMessage = "{0} cannot be empty!")]
        public string Status { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "{0} cannot be empty!")]
        public String Desc { get; set; }

        
       

    }
}
