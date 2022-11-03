var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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

//routes.MapRoute("Index", "", new { controller = "Home", action = "Index" });
//routes.MapRoute("Tests", "Tests/{*view}", new { controller = "Tests", action = "Tests" });
//routes.MapRoute("MvcTests", "MvcTests/{*view}", new { controller = "MvcTests", action = "MvcTests" });

app.MapControllerRoute(
    name: "index",
    pattern: "{controller=Home}/{action=Index}");
app.MapControllerRoute(
    name: "tests",
    pattern: "Tests/{*view}",
    defaults: new { controller = "Tests", action = "Tests" });
app.MapControllerRoute(
    name: "mvctests",
    pattern: "MvcTests/{*view}",
    defaults: new { controller = "MvcTests", action = "MvcTests" });

app.Run();
