using JcIO.Site.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MeuDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("MeuDbContext"))
    );

builder.Services.AddTransient<IPedidoRepository, PedidoRepository>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    //app.UseExceptionHandler("Home/Error");
    app.UseHsts();
}

app.UseStaticFiles();

//app.MapControllerRoute(
//    name: "areas",
//    pattern: "{area:exists}/{controller=Cadastro}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default", 
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapAreaControllerRoute(
    name: "AreaVendas",
    areaName: "Vendas",
    pattern: "{controller=Pedidos}/{action=Index}/{id?}");

app.Run();
