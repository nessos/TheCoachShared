using System;
using System.Collections.Generic;
using System.Text;

namespace TheCoach.Web.Models.GetDTO
{
	public class NotificationUserDto
	{
		public string Id { get; set; }

		public string Email { get; set; }

		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string NotificationToken { get; set; }
		public string AppVersion { get; set; }
		public string DeviceInfo { get; set; }
		public string DeviceTypeId { get; set; }
	}
}
