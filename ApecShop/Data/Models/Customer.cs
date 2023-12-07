using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApecShop.Data.Models
{
    public class Customer : CreatedModified
    {
        [Key]
        public int CustomerID { get; set; }
        [StringLength(100)]
        public string? FName { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string LName { get; set; } = string.Empty;
        public int GenderID { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime PaymentConditionId { get; set; }

        [Column(TypeName ="decimal(5,4)")]  
        public decimal Discount { get; set; }

        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual Gender Gender { get; set; } = null!;

    }
}
