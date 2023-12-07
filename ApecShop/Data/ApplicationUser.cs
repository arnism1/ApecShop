using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ApecShop.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [StringLength(100)]
        public string? FName { get; set; }
        [StringLength(100)]
        public string? LName { get; set; }
    }

}
