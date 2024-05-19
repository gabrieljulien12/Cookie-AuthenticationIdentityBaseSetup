namespace Cookie_Based_AuthenticationWithIdentityBaseSetup.Models.Entities
{
    public class Product:BaseEntity
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int? CatagoryId { get; set; }
        //Relations Proporties

        public virtual required Catagory Catagory { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }  
    }
}
