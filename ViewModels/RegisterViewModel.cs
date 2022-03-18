namespace TomasosPizzeria.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Namn är obligatoriskt.")]
        [MaxLength(100, ErrorMessage = "Namn får max bestå av 100 karaktärer.")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Adress är obligatoriskt.")]
        [MaxLength(50, ErrorMessage = "Adress får max bestå av 20 karaktärer.")]
        public string Street { get; set; } = null!;

        [Required(ErrorMessage = "Postnummer är obligatoriskt.")]
        [DataType(DataType.PostalCode)]
        [MaxLength(20, ErrorMessage = "Postnummer får max bestå av 20 karaktärer.")]
        public string ZipCode { get; set; } = null!;

        [Required(ErrorMessage = "Postort är obligatoriskt.")]
        [MaxLength(100, ErrorMessage = "Postort får max bestå av 100 karaktärer.")]
        public string City { get; set; } = null!;

        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "Ogiltig epostadress.")]
        [MaxLength(50, ErrorMessage = "Epostadress får max bestå av 50 karaktärer.")]
        public string Email { get; set; } = null!;

        [DataType(DataType.PhoneNumber)]
        [Phone(ErrorMessage = "Ogiltigt nummer.")]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Telefonnummer måste bestå av 8-50 karaktärer.")]
        public string PhoneNumber { get; set; } = null!;

        [Required(ErrorMessage = "Användarnamn är obligatoriskt.")]
        [MaxLength(20, ErrorMessage = "Användarnamn får max bestå av 20 karaktärer.")]
        public string UserName { get; set; } = null!;

        [DataType(DataType.Password)]   
        [Required(ErrorMessage = "Lösenord är obligatoriskt.")]       
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Lösenord måste bestå av 6-20 karaktärer.")]
        public string Password { get; set; } = null!;

    }
}
