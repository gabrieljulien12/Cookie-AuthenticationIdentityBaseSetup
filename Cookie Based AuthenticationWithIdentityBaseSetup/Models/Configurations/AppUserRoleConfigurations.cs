using Cookie_Based_AuthenticationWithIdentityBaseSetup.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cookie_Based_AuthenticationWithIdentityBaseSetup.Models.Configurations
{
    public class AppUserRoleConfigurations:BaseConfigurations<AppUserRole>
    {
        public override void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            base.Configure(builder);
            builder.Ignore(x => x.Id);
            builder.HasKey(x => new
            {
                x.UserId,
                x.RoleId
            });
        }
    }
}
