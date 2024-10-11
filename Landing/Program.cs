using System.Globalization;
using Dal;
using Dal.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromHours(3);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});
builder.Services.AddDistributedMemoryCache();
builder.Services.AddInfrastructureServices();

// Configure DbContext
builder.Services.AddDbContext<Dal.DataBase.AppContext>(s =>
    s.UseSqlServer(
        "Data Source=185.165.118.72;Initial Catalog=Landing;User ID=Pars_User;Password=I$w225am!K;Trust Server Certificate=True"));

// Configure Identity
builder.Services.AddIdentity<User, Role>(option =>
    {
        option.Password.RequireDigit = false;
        option.Password.RequireLowercase = false;
        option.Password.RequireNonAlphanumeric = false;
        option.Password.RequireUppercase = false;
        option.Password.RequiredLength = 4;
        option.SignIn.RequireConfirmedPhoneNumber = false;
        option.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromHours(3);
    })
    .AddUserManager<UserManager<User>>()
    .AddEntityFrameworkStores<Dal.DataBase.AppContext>();

// Configure SecurityStampValidator to prevent frequent logouts
builder.Services.Configure<SecurityStampValidatorOptions>(options =>
{
    options.ValidationInterval = TimeSpan.FromHours(3); // بررسی کوکی هر 3 ساعت یک بار
});
builder.Services.AddLocalization(options => options.ResourcesPath = "Resources");

builder.Services.Configure<RequestLocalizationOptions>(options =>
{
    var supportedCultures = new List<CultureInfo>
    {
        new CultureInfo("en"),
        new CultureInfo("fa")
    };

    options.DefaultRequestCulture = new RequestCulture("en");
    options.SupportedCultures = supportedCultures;
    options.SupportedUICultures = supportedCultures;
});

builder.Services.AddControllersWithViews()
    .AddViewLocalization()
    .AddDataAnnotationsLocalization();

// Configure CORS policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigin",
        builder =>
        {
            builder.WithOrigins("http://127.0.0.1:5500")
                .AllowAnyHeader()
                .AllowAnyMethod()
                .AllowCredentials();
        });
});

// Configure cookie settings
builder.Services.ConfigureApplicationCookie(options =>
{
    options.AccessDeniedPath = "/Admin/AccessDenied";
    options.Cookie.Name = "webappPanel";
    options.ExpireTimeSpan = TimeSpan.FromHours(3);
    options.LoginPath = "/Admin/Login";
    options.SlidingExpiration = true;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

var localizationOptions = app.Services.GetRequiredService<IOptions<RequestLocalizationOptions>>().Value;
app.UseRequestLocalization(localizationOptions);

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseCors("AllowSpecificOrigin");

app.UseSession();
app.UseAuthentication(); // باید قبل از UseAuthorization فراخوانی شود
app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();