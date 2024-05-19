using System.Security.Cryptography.X509Certificates;

namespace Cookie_Based_AuthenticationWithIdentityBaseSetup.Models.Entities
{
    public class OrderDetail:BaseEntity
    {
       public int OrderId { get; set; }
        public int ProductId { get; set; }
        
        //Relation Proporties
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
