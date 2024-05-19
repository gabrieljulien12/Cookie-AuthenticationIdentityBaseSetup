using Cookie_Based_AuthenticationWithIdentityBaseSetup.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cookie_Based_AuthenticationWithIdentityBaseSetup.Models.Configurations
{
    public class CatagoryCongigurations:BaseConfigurations<Catagory>
    {
        public override void Configure(EntityTypeBuilder<Catagory> builder)
        {
            base.Configure(builder);    
        }
    }
}
