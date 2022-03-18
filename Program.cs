var builder = WebApplication.CreateBuilder(args); // Service container

#region TomasosDb
// Connectionstring, denna ligger gömd i appsettings.json
var conn = builder.Configuration.GetConnectionString("DefaultConnection");

// Sätter upp tjänst som gör att man kan använda EF i applikationen (inject)
builder.Services.AddDbContext<TomasosDBContext>(options => options.UseSqlServer(conn))
                // Sedan sätter man upp Identity som bygger på EF
                .AddDbContext<ApplicationDbContext>(options =>options.UseSqlServer(conn))
                .AddIdentity<ApplicationUser, IdentityRole>(options => {
                    options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+/! ";
                })
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();
#endregion

//#region Session & Identity
// Sätter upp tjänst för att distribuera cache:n
builder.Services.AddDistributedMemoryCache();

// Sätter upp sessions-tjänst med timeout på 30 min
builder.Services.AddSession(options => options.IdleTimeout = TimeSpan.FromMinutes(30));

////#endregion

// Sätter upp ett repo som en service som injektas till applikationen
builder.Services.AddTransient<IFoodRepo, FoodRepo>();

builder.Services.AddMvc(options => options.EnableEndpointRouting = false);

// Request pipeline 
var app = builder.Build();

#region Session & Authentication
// Tillåter applikationen att använda sessioner
app.UseSession();


// Sätter upp identity i vår pipeline dvs att en request ska kunna hantera inloggningar/behörighet
app.UseAuthentication();
#endregion

// Tillåter applikationen att hantera statiska filer (t.ex. bilder, css och js)
app.UseStaticFiles();

// Startroute, här kan annan controller och action anges
app.UseMvc(routes =>
{
    routes.MapRoute(
    name: "default",
    template: "{controller=Home}/{action=Index}");
});

app.Run();
