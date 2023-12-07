using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace ApecShop.Data.Models
{
    public class Gender
    {
        [Key]
        public int GenderID { get; set; }

        [Required]
        [StringLength(30, MinimumLength =1)]

        public string Title { get; set; }  = String.Empty;

        [StringLength(500)]
        public string? Notes { get; set; }

        public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();    
    }
}
