namespace TheCoach.Web.Models.Binding
{
	using System.Diagnostics.CodeAnalysis;

	/// <summary>
	/// A wrapper for human-friendly JWT token representation.
	/// </summary>
	[SuppressMessage(
		"Stylecop.Csharp",
		"SA1623: PropertySummaryDocumentationMustMatchAccessors",
		Justification = "DTO object")]
	[SuppressMessage(
		"Stylecop.Csharp",
		"SA1300: PropertySummaryDocumentationMustMatchAccessors",
		Justification = "DTO object")]
	public class UserAuthDTO
	{
		/// <summary>
		/// Encoded JWT token with all claims embedded.
		/// </summary>
		public string access_token { get; set; }

		/// <summary>
		/// Type of access token.
		/// </summary>
		public string token_type { get; set; }

		/// <summary>
		/// Unix epoch time when token expires.
		/// </summary>
		public long expires_in { get; set; }

		/// <summary>
		/// Identity roles that the user is a member of.
		/// </summary>
		public string roles { get; set; }

		public string firstName { get; set; }

		public string lastName { get; set; }

		public string email { get; set; }

		public string phoneNumber { get; set; }

		/// <summary>
		/// UTC timestamp of issuing time.
		/// </summary>
		public string issued { get; set; }

		/// <summary>
		/// UTC timestamp of expiration time.
		/// </summary>
		public string expires { get; set; }
	}
}
