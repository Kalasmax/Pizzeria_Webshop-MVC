namespace TomasosPizzeria.ModelsIdentity
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
           
        }
        protected override void OnModelCreating(ModelBuilder builder)
        { base.OnModelCreating(builder); }
    }
}
