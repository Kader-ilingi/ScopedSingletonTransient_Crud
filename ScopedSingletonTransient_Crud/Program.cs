using ScopedSingletonTransient_Crud.Models.NorthwindData;
using ScopedSingletonTransient_Crud.Repositories.Abstracts;
using ScopedSingletonTransient_Crud.Repositories.Concretes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<NorthwindContext, NorthwindContext>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
//builder.Services.AddScoped<IProductService, ProductService>();
//builder.Services.AddScoped<ISupplierService, SupplierService>()
builder.Services.AddSingleton<NorthwindContext, NorthwindContext>();
builder.Services.AddSingleton<ICategoryService, CategoryService>();

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
