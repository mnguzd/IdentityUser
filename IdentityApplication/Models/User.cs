using Microsoft.AspNetCore.Identity;

namespace IdentityApplication.Models
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
    }
}
