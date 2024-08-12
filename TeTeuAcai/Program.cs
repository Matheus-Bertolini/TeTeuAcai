using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TeTeuAcai.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
string conn = builder.Configuration.GetConnectionString("Conexao");
var server = ServerVersion.AutoDetect(conn);
builder.Services.AddDbContext<TeteuAcaiContext>(
    options => options.UseMySql(conn, server)
);

builder.Services.AddIdentity<IdentityUser, IdentityRole>()
.AddEntityFrameworkStores<TeteuAcaiContext>()
.AddDefaultTokenProviders();


builder.Services.AddControllersWithViews();

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
