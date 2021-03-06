using System;

namespace TheCoach.Web.Models.Binding
{
	public class PurchaseLessonBindingModel
	{
		public long LessonId { get; set; }
		public string PackageName { get; set; }
		public string OrderId { get; set; }
		public string DevicePlatform { get; set; }
		public string StoreProductId { get; set; }
		public string PurchaseToken { get; set; }
		public PurchaseState State { get; set; }
		public DateTime TransactionDateUtc { get; set; }
	}
}
