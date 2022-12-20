using DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//Services
builder.Services.AddControllersWithViews();
//var connectionString = "Server=DESKTOP-V89J39Q;Database=ProniaDB;Trusted_Connection=True";
var connectionString = builder.Configuration["ConnectionStrings:Default"];

builder.Services.AddDbContext<AppDbContext>(opt =>
{

    opt.UseSqlServer(connectionString);

});

var app = builder.Build();
app.UseStaticFiles();

//handler
app.MapControllerRoute(

    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
    );

app.Run();
