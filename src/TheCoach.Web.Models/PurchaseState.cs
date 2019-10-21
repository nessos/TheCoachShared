namespace TheCoach.Web.Models 
{ 
	public enum PurchaseState
	{
		/// <summary>Purchased and in good standing</summary>
		Purchased,
		/// <summary>Purchase was canceled</summary>
		Canceled,
		/// <summary>Purchase was refunded</summary>
		Refunded,
		/// <summary>In the process of being processed</summary>
		Purchasing,
		/// <summary>Transaction has failed</summary>
		Failed,
		/// <summary>Was restored.</summary>
		Restored,
		/// <summary>In queue, pending external action</summary>
		Deferred,
		/// <summary>In free trial</summary>
		FreeTrial,
		/// <summary>Pending Purchase</summary>
		PaymentPending,
		/// <summary>Purchase state unknown</summary>
		Unknown,
	}
}
