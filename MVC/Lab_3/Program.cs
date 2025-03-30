var builder = WebApplication.CreateBuilder(args);

// ��������� �������, ����������� ��� MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// ����������� �������� ��������� HTTP-��������
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// ����������� �������������
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{hel?}");

app.Run();