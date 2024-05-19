using Cookie_Based_AuthenticationWithIdentityBaseSetup.Models.Enums;
using Cookie_Based_AuthenticationWithIdentityBaseSetup.Models.Services;

namespace Cookie_Based_AuthenticationWithIdentityBaseSetup.Models.Entities
{
    public abstract class BaseEntity : Ientity
    {
        protected BaseEntity()
        {
            CreatedDate = DateTime.Now;
            Status =DataStatus.Inserted;
        }
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public DataStatus Status { get; set; }

    }
}
