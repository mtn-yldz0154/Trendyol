using Microsoft.AspNetCore.Identity;

namespace Trendyol.Identity
{
    public class User:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PP { get; set; }


    }
}
