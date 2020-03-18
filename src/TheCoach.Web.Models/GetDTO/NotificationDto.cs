using System;
using System.Collections.Generic;
using System.Text;

namespace TheCoach.Web.Models.GetDTO
{
	public class NotificationDto
	{
		public long Id { get; set; }
		public string DeviceTypeId { get; set; }
		public string Token { get; set; }
		public string Type { get; set; }
		public string Display { get; set; }
		public string Data { get; set; }
		public int AppType { get; set; }
		public string AppVersion { get; set; }
		public string DeviceInfo { get; set; }
		public bool ServiceSuccess { get; set; }
		public string ServiceResponse { get; set; }
		public bool Delivered { get; set; }
		public DateTime DeliveredDateTime { get; set; }
		public DateTime Created { get; set; }
		public string User_Id { get; set; }
	}
}
