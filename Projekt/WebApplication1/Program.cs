using Microsoft.EntityFrameworkCore;
using ZadaniaDomowe.Data;
using ZadaniaDomowe.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ZadanieDane>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ZadanieDane")));

builder.Services.AddControllersWithViews();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<ZadanieDane>();
    context.Database.EnsureCreated();
    SeedData.Initialize(services);
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Zadania}/{action=Index}/{id?}");

app.Run();