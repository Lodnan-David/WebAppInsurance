using Microsoft.AspNetCore.Identity;
namespace WebAppInsurance.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}
