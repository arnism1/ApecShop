using System.ComponentModel.DataAnnotations;

namespace ApecShop.Data.DTOs
{
    public class GenderDetail
    {
        [Key]
        public int GenderID { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 1)]

        public string Title { get; set; } = String.Empty;

        [StringLength(500)]
        public string? Notes { get; set; }
    }
}
