var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

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

// ������� �� �������������: ��������� Page1, �� Index
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Page1}/{action=Index}/{id?}" 
);

app.Run(); 
