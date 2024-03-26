using ApplicationCore.Contracts.RepositoryInterface.Customer.Repository;
using ApplicationCore.Contracts.RepositoryInterface.ProductIRepo;
using Infrastructure.Data;
using Infrastructure.Repositories.CustomerRepo;
using Infrastructure.Repositories.ProductRepo;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// attach it to connectionstring
builder.Services.AddDbContext<EShopDbContext>(option =>
{
    option.UseSqlServer(Environment.GetEnvironmentVariable("EShopDB"));
    //option.UseSqlServer(builder.Configuration.GetConnectionString("EShopDB"));
});

// repository must be registered in MVC 
// dependency injection
builder.Services.AddScoped<ICustomerRepo, CustomerRepo>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();