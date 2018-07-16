namespace TheCoach.Web.Models.Binding
{
	using System.ComponentModel.DataAnnotations;
	using System.Diagnostics.CodeAnalysis;

	/// <summary>
	/// Binding model used to register a new user
	/// </summary>
	[SuppressMessage(
		"Stylecop.Csharp",
		"SA1623: PropertySummaryDocumentationMustMatchAccessors",
		Justification = "DTO object")]
	public class RegisterBindingModel
	{
		[Required] public string FirstName { get; set; }

		[Required] public string LastName { get; set; }

		[Required] [Display(Name = "Email")] public string Email { get; set; }

		public string PhoneNumber { get; set; }

		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		[DataType(DataType.Password)]
		[Compare("Password", ErrorMessage = "Password and confirmation do not match")]
		public string ConfirmPassword { get; set; }
	}
}
