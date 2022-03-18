namespace TomasosPizzeria.ModelsIdentity
{
    public class ApplicationUser : IdentityUser
    {
        // Man får med ganska många(ca 15) properties för en user
        // Lägger vi på lite extrAa property som inte fanns med

        public string Name { get; set; } = null!;
        public string Street { get; set; } = null!;
        public string ZipCode { get; set; } = null!;
        public string City { get; set; } = null!;

        public string Password { get; set; } = null!;

    }
}
