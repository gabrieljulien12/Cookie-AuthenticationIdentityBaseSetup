using Cookie_Based_AuthenticationWithIdentityBaseSetup.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cookie_Based_AuthenticationWithIdentityBaseSetup.Models.Configurations
{
    public class AppRoleConfigurations:BaseConfigurations<AppRole>
    {
        public override void Configure(EntityTypeBuilder<AppRole> builder)
        {
            base.Configure(builder);
            
            builder.HasMany(x => x.UserRoles).WithOne(x => x.Role).HasForeignKey(x => x.RoleId).IsRequired();
        }
    }
}
