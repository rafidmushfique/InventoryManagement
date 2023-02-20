using InventoryManagement.Models;
using InventoryManagement.Models.Domain;
using InventoryManagement.Repository.Abstract;
using InventoryManagement.Repository.Implementation;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//DB Connection Establishment
builder.Services.AddDbContext<INVDbContext>(
    optionx => optionx.UseSqlServer(
         builder.Configuration.GetConnectionString("ImsConn")
        )
    );
//Interfaces Intilization
builder.Services.AddScoped<ICategoryService,CategoryService>();
builder.Services.AddScoped<IOrderService, OrderService>();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IProductService, Productservice>();
builder.Services.AddScoped<ISupplierService, SupplierService>();
builder.Services.AddScoped<IUserService, UserService>();

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
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
