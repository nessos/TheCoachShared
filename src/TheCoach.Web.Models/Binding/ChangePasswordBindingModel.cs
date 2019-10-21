using System.ComponentModel.DataAnnotations;

namespace TheCoach.Web.Models.Binding
{
	public class ChangePasswordBindingModel
	{
		[Required]
		[DataType(DataType.Password)]
		public string OldPassword { get; set; }

		[Required]
		[DataType(DataType.Password)]
		public string NewPassword { get; set; }

		[DataType(DataType.Password)]
		[Compare("NewPassword", ErrorMessage = "New password and confirmation do not match")]
		public string ConfirmPassword { get; set; }

	}
}
