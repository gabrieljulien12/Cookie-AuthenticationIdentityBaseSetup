using Cookie_Based_AuthenticationWithIdentityBaseSetup.Models.Configurations;
using Cookie_Based_AuthenticationWithIdentityBaseSetup.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Cookie_Based_AuthenticationWithIdentityBaseSetup.Models.Context
{
    public class MyContext : IdentityDbContext<AppUser, AppRole, int,IdentityUserClaim<int>,AppUserRole,IdentityUserLogin<int>,IdentityRoleClaim<int>,IdentityUserToken<int>>
    {
        public MyContext(DbContextOptions<MyContext> opt): base (opt)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration( new AppRoleConfigurations());
            builder.ApplyConfiguration(new AppUserConfigurations());
            builder.ApplyConfiguration(new AppUserRoleConfigurations());
            builder.ApplyConfiguration(new CatagoryCongigurations());
            builder.ApplyConfiguration(new OrderConfigurations());
            builder.ApplyConfiguration(new OrderDetailConfiguration());
            builder.ApplyConfiguration(new ProductConfigurations());
            builder.ApplyConfiguration(new ProfileConfigurations());

        }
        public DbSet<AppRole>AppRoles{ get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppUserProfile> Profiles { get; set; }
        public DbSet<AppUserRole>AppUserRoles { get; set; }
        public DbSet<Catagory> Catagories { get; set; }
        public DbSet<Order>Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product>Products { get; set; }
}
}
