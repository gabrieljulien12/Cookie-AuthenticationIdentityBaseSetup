using Cookie_Based_AuthenticationWithIdentityBaseSetup.Models.Enums;
using Cookie_Based_AuthenticationWithIdentityBaseSetup.Models.Services;
using Microsoft.AspNetCore.Identity;
using System.Security.Cryptography.X509Certificates;

namespace Cookie_Based_AuthenticationWithIdentityBaseSetup.Models.Entities
{
    public class AppUser : IdentityUser<int>, Ientity
    {
        public AppUser()
        {
            CreatedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }
    
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public DataStatus Status { get; set; }

        //Relations Proporties
        public virtual ICollection<AppUserRole> UserRoles { get; set; } 
        public virtual AppUserProfile Profile { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
