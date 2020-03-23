using System.ComponentModel.DataAnnotations;

namespace TheCoach.Web.Models.Binding
{
	public class DeviceTokenBindingModel
	{
		[Required]
		public string Token { get; set; }

		/// <summary>
		/// [iOS | Android]
		/// </summary>
		public string DeviceTypeId { get; set; }

		public string AppVersion { get; set; }

		public string DeviceInfo { get; set; }
	}
}
