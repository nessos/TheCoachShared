namespace TheCoach.Web.Models.Binding
{
	using System.ComponentModel.DataAnnotations;
	using System.Diagnostics.CodeAnalysis;

	/// <summary>
	/// Binding model used to login.
	/// </summary>
	[SuppressMessage(
		"Stylecop.Csharp",
		"SA1623: PropertySummaryDocumentationMustMatchAccessors",
		Justification = "DTO object")]
	public class LoginBindingModel
	{
		/// <summary>
		/// User email.
		/// </summary>
		[Required]
		public string Email { get; set; }

		/// <summary>
		/// User password.
		/// </summary>
		[Required]
		public string PassWord { get; set; }
	}
}
