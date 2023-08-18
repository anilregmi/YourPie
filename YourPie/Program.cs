using Microsoft.EntityFrameworkCore;
using YourPie;
using YourPie.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IPieRepository, PieRepository>();

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<YourPieDbContext>(options => {
    options.UseSqlServer(
        builder.Configuration["ConnectionStrings:YourPieDbContextConnection"]);
});

var app = builder.Build();

app.UseStaticFiles();
app.UseDeveloperExceptionPage();
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
app.MapDefaultControllerRoute();

app.Run();
