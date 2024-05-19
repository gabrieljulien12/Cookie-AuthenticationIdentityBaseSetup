using Cookie_Based_AuthenticationWithIdentityBaseSetup.Models.Enums;

namespace Cookie_Based_AuthenticationWithIdentityBaseSetup.Models.Services
{
    public interface Ientity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeleteDate { get; set; }
        public DataStatus Status { get; set; }
    }
}
