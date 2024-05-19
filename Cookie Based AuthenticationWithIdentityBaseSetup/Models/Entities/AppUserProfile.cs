namespace Cookie_Based_AuthenticationWithIdentityBaseSetup.Models.Entities
{
    public class AppUserProfile:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Relations Proporties
        public virtual AppUser AppUser { get; set; }
    }
}
