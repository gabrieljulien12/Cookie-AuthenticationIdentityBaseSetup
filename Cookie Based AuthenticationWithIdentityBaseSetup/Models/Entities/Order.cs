namespace Cookie_Based_AuthenticationWithIdentityBaseSetup.Models.Entities
{
    public class Order:BaseEntity
    {
        public string ShippingAddres { get; set; }
        public int AppuserId { get; set; }

        //Relations Proporties
        public virtual AppUser AppUser { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

    }
}
