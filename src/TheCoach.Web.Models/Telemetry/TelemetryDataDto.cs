using System;

namespace TheCoach.Web.Models.Telemetry
{
	using TheCoach.Web.Models.Discriminators;

	public class TelemetryDataDto
	{
		public TelemetryEvent Event { get; set; }

		public DateTime Time { get; set; }

		public long EntityIdentifier { get; set; }
	}
}
