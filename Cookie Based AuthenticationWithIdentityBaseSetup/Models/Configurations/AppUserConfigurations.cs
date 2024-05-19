using Cookie_Based_AuthenticationWithIdentityBaseSetup.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cookie_Based_AuthenticationWithIdentityBaseSetup.Models.Configurations
{
    public class AppUserConfigurations: BaseConfigurations<AppUser>
    {
        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {
            base.Configure(builder);
            
            builder.HasOne(x=> x.Profile).WithOne(x => x.AppUser).HasForeignKey<AppUserProfile>(x => x.Id);
            builder.HasMany(x => x.Orders).WithOne(x => x.AppUser).HasForeignKey(x => x.AppuserId);
            builder.HasMany(x => x.UserRoles).WithOne(x => x.User).HasForeignKey(x => x.UserId).IsRequired();
        }
    }
}
