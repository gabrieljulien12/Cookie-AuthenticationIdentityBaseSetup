using Cookie_Based_AuthenticationWithIdentityBaseSetup.Models.Context;
using Cookie_Based_AuthenticationWithIdentityBaseSetup.Models.Entities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddIdentity<AppUser, AppRole>(opt =>
{
    opt.Password.RequiredLength = 3;
    opt.Password.RequireLowercase = false;
    opt.Password.RequireNonAlphanumeric = false;
    opt.SignIn.RequireConfirmedEmail = false;
    opt.Password.RequireUppercase = false;
    opt.Password.RequireDigit = false;


}).AddEntityFrameworkStores<MyContext>();

builder.Services.ConfigureApplicationCookie(opt =>
{ 
    opt.Cookie.HttpOnly = true;
    opt.ExpireTimeSpan = TimeSpan.FromMinutes(5);
    opt.SlidingExpiration = true;
    opt.Cookie.Name = "Cyfer";
    opt.Cookie.SameSite = SameSiteMode.Strict;
    opt.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;
    opt.LoginPath = new PathString("/Auth/SýgIn");
});

builder.Services.AddDbContext<MyContext>(opt =>
opt.UseSqlServer(builder.Configuration.GetConnectionString("Myconnection")).UseLazyLoadingProxies());

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Auth}/{action=Register}/{id?}");

app.Run();
