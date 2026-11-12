using GoldfieldsConnect.Configuration;
using GoldfieldsConnect.Database;
using GoldfieldsConnect.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.Cookies; // Added for Auth

var builder = WebApplication.CreateBuilder(args);

// 1. Add services to the container.
builder.Services.AddControllersWithViews();

// 2. Bind Supabase Settings from appsettings.json
builder.Services.Configure<SupabaseSettings>(builder.Configuration.GetSection("SupabaseSettings"));

// 3. Register the Supabase Service for Dependency Injection
builder.Services.AddSingleton<SupabaseService>();

// 4. Register Entity Framework Core with Npgsql (PostgreSQL)
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

// 5. Add Cookie Authentication
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Auth/Login";
        options.LogoutPath = "/Auth/Logout";
        options.AccessDeniedPath = "/Auth/AccessDenied";
        options.ExpireTimeSpan = TimeSpan.FromHours(2); // Session expires after 2 hours
        options.SlidingExpiration = true;
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // We will create an Error action later. For now, it prevents crashes.
    app.UseExceptionHandler("/Welcome/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// 6. IMPORTANT: Authentication MUST come before Authorization
app.UseAuthentication();
app.UseAuthorization();

// 7. Updated Default Route to point to Welcome Controller instead of Home
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Welcome}/{action=Index}/{id?}");


using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        var context = services.GetRequiredService<ApplicationDbContext>();
        var supabaseService = services.GetRequiredService<SupabaseService>();

        // This will run the seeder
        GoldfieldsConnect.Database.SeedData.Initialize(context, supabaseService).Wait();
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred while seeding the database.");
    }
}
app.Run();