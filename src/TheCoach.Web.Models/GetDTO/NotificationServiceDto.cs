using System;
using System.Collections.Generic;
using System.Text;

namespace TheCoach.Web.Models.GetDTO
{
	public class NotificationServiceDto
	{
		public long Id { get; set; }
		public string Token { get; set; }
		public DateTime ExpirationTimeStamp { get; set; }
		public string User_Id { get; set; }
		public DateTime Created { get; set; }
		public string DeviceTypeId { get; set; }
		public string AppType { get; set; }
		public string AppVersion { get; set; }
		public string DeviceInfo { get; set; }
	}
}
