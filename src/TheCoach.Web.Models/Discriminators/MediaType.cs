namespace TheCoach.Web.Models
{
	public enum MediaType
	{
		None = 0,
		Text = 1,
		Audio = Text << 1,
		Video = Text << 2,
		Photo = Text << 3
	}
}
