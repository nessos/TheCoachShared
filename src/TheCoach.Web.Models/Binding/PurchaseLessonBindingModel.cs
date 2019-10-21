using System;

namespace TheCoach.Web.Models.Binding
{
	public class PurchaseLessonBindingModel
	{
		public int LessonId { get; set; }
		public string StoreProductId { get; set; }
		public string PurchaseToken { get; set; }
		public PurchaseState State { get; set; }
		public DateTime TransactionDateUtc { get; set; }
	}
}
