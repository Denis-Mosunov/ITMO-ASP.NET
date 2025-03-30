var builder = WebApplication.CreateBuilder(args);

// Добавляем сервисы, необходимые для MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Настраиваем конвейер обработки HTTP-запросов
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Настраиваем маршрутизацию
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{hel?}");

app.Run();