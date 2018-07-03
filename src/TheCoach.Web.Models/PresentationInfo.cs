namespace TheCoach.Web.Models
{
	using System;

	public class PresentationInfo
	{
		public TimeSpan Time { get; set; }

		public float Pitch { get; set; }

		public float Speed { get; set; }

		public int RepeatTimes { get; set; }
	}
}
