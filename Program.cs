var builder = WebApplication.CreateBuilder(args); // Service container

#region TomasosDb
// Connectionstring, denna ligger g�md i appsettings.json
var conn = builder.Configuration.GetConnectionString("DefaultConnection");

// S�tter upp tj�nst som g�r att man kan anv�nda EF i applikationen (inject)
builder.Services.AddDbContext<TomasosDBContext>(options => options.UseSqlServer(conn))
                // Sedan s�tter man upp Identity som bygger p� EF
                .AddDbContext<ApplicationDbContext>(options =>options.UseSqlServer(conn))
                .AddIdentity<ApplicationUser, IdentityRole>(options => {
                    options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+/! ";
                })
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();
#endregion

//#region Session & Identity
// S�tter upp tj�nst f�r att distribuera cache:n
builder.Services.AddDistributedMemoryCache();

// S�tter upp sessions-tj�nst med timeout p� 30 min
builder.Services.AddSession(options => options.IdleTimeout = TimeSpan.FromMinutes(30));

////#endregion

// S�tter upp ett repo som en service som injektas till applikationen
builder.Services.AddTransient<IFoodRepo, FoodRepo>();

builder.Services.AddMvc(options => options.EnableEndpointRouting = false);

// Request pipeline 
var app = builder.Build();

#region Session & Authentication
// Till�ter applikationen att anv�nda sessioner
app.UseSession();


// S�tter upp identity i v�r pipeline dvs att en request ska kunna hantera inloggningar/beh�righet
app.UseAuthentication();
#endregion

// Till�ter applikationen att hantera statiska filer (t.ex. bilder, css och js)
app.UseStaticFiles();

// Startroute, h�r kan annan controller och action anges
app.UseMvc(routes =>
{
    routes.MapRoute(
    name: "default",
    template: "{controller=Home}/{action=Index}");
});

app.Run();
