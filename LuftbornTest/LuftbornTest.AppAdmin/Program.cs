using AutoMapper;
using DAL;
using LuftbornTest.AppAdmin.AutoMapper;
using Microsoft.EntityFrameworkCore;
using Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddSession(opt => opt.IdleTimeout = TimeSpan.FromHours(4));
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

builder.Services.AddDbContext<DataContext>(opt=>opt.UseLazyLoadingProxies().UseSqlServer(builder.Configuration.GetConnectionString("DefultConnection")));
builder.Services.AddScoped<UnitOfWork>();
builder.Services.AddAutoMapper(s=>s.AddProfile<AutoMapping>(),typeof(Program));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseSession();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
