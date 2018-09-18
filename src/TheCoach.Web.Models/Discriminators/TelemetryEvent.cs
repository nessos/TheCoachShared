namespace TheCoach.Web.Models.Discriminators
{
	public enum TelemetryEvent
	{
		Unknown = 0,
		LocalPlaylistCreated = 1,
		PlaylistDownloaded = 2,
		PlaylistStarted = 3,
		PlaylistStopped = 4,
	}
}
