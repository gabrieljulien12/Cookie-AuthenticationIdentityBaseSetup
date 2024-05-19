using Cookie_Based_AuthenticationWithIdentityBaseSetup.Models.Enums;
using Cookie_Based_AuthenticationWithIdentityBaseSetup.Models.Services;
using Microsoft.AspNetCore.Identity;

namespace Cookie_Based_AuthenticationWithIdentityBaseSetup.Models.Entities
{
    public class AppUserRole : IdentityUserRole<int>, Ientity
    {
        public AppUserRole()
        {
            CreatedDate = DateTime.Now;
            Status = DataStatus.Inserted;
        }
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public DataStatus Status { get; set; }

        //Relations Proporties
        public virtual AppUser User { get; set; }
        public virtual AppRole Role { get; set; }

    }
}
