using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApecShop.Data.Models
{
    public class CreatedModified
    {
        [StringLength(450)]
        public DateTime Created { get; set; }
        [StringLength(450)]
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime? Modified { get; set; }
        public string ModifiedBy { get; set; } = string.Empty;

        [Required]
        [ForeignKey(nameof(CreatedBy))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public ApplicationUser UserCreated { get; set; } = null!;

        [ForeignKey(nameof(ModifiedBy))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public ApplicationUser? UserModified { get; set; } = null!;
    }
}
