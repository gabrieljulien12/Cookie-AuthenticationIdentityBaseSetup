using Cookie_Based_AuthenticationWithIdentityBaseSetup.Models.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cookie_Based_AuthenticationWithIdentityBaseSetup.Models.Configurations
{
    public abstract class BaseConfigurations<T> : IEntityTypeConfiguration<T> where T : class, Ientity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder) // virtual yapmamızın sebebi polimorfezim
        {
            
        }
    }
}
