using Cookie_Based_AuthenticationWithIdentityBaseSetup.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cookie_Based_AuthenticationWithIdentityBaseSetup.Models.Configurations
{
    public class OrderDetailConfiguration:BaseConfigurations<OrderDetail>
    {
        public override void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            base.Configure(builder);
            builder.Ignore(x => x.Id);
            builder.HasKey(x => new
            {
                x.OrderId,
                x.ProductId
            });
        }
    }
}
