using _2301010065_yahoang_th01.models.Services;
using _2301010065_yahoang_th01.modes.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<CoffeeshopDbContext>(option =>
option.UseSqlServer(builder.Configuration.GetConnectionString("CoffeeShopDbContextConnection"))); 

builder.Services.AddScopped<IProductRepository, ProductRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages(
    name: "default",
    pattern: "{controller=home}/{ action = index}/{ id?}");

app.Run();
