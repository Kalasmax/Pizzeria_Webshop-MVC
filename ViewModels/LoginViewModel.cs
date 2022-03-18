namespace TomasosPizzeria.ViewModels
{
	public class LoginViewModel
	{
		[Required(ErrorMessage = "Var god ange ditt användarnamn.")]
		[MaxLength(20, ErrorMessage = "Användarnamn får max bestå av 20 karaktärer.")]
		public string UserName { get; set; } = null!;

		[DataType(DataType.Password)]
		[Required(ErrorMessage = "Var god ange ditt lösenord.")]
		[StringLength(20, MinimumLength = 6, ErrorMessage = "Lösenord måste bestå av 6-20 karaktärer.")]
		public string Password { get; set; } = null!;

	}
}
