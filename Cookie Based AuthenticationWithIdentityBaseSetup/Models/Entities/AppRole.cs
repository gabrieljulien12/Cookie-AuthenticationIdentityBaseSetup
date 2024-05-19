using Cookie_Based_AuthenticationWithIdentityBaseSetup.Models.Enums;
using Cookie_Based_AuthenticationWithIdentityBaseSetup.Models.Services;
using Microsoft.AspNetCore.Identity;

namespace Cookie_Based_AuthenticationWithIdentityBaseSetup.Models.Entities
{
    public class AppRole : IdentityRole<int>, Ientity
    {
        public AppRole()
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
    }
}
