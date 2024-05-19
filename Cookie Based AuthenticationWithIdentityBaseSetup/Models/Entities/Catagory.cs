namespace Cookie_Based_AuthenticationWithIdentityBaseSetup.Models.Entities
{
    public class Catagory:BaseEntity
    {
        public string CatagoryName { get; set; }
        public string Description { get; set; }

        //Relations Proporties
        public virtual ICollection<Product> Products { get; set; }  
    }
}
