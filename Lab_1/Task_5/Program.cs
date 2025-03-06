using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

// ������ �������� ���� � ������������� DMC
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    // ��� ����� ���
    options.IdleTimeout = TimeSpan.FromMinutes(20);
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts(); 
}

app.UseHttpsRedirection(); 
app.UseStaticFiles();        

app.UseRouting();           
app.UseAuthorization();     

// ��������� ���
app.UseSession();

// ������������ ������� �� ������������� Page1/Index
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Page1}/{action=Index}/{id?}"
);

app.Run(); 
