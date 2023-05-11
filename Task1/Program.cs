using Microsoft.EntityFrameworkCore;
using Task1.DataAccessLayer;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(option =>
{
    option.UseSqlServer("Server=MSI\\SQLEXPRESS;DataBase=Task1Db;Trusted_Connection=true;");
});

var app = builder.Build();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=home}/{action=index}/{id?}"
    );


app.Run();
