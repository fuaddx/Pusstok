using Microsoft.EntityFrameworkCore;
using Pustok2.Contexts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<PustokDbContent>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("MSSql"));
    //or option.UseSqlServer(builder.Configuration[GetConnectionString:"MSSql"]);
});
// ne vaxt Pustok istesem konstruktorda New la ver mene 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "Areas",
    pattern: "{area:exists}/{controller=Slider}/{action=Index}/{id?}"
);
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();
