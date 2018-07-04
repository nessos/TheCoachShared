namespace TheCoach.Web.Models.Discriminators
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum MediaType
	{
		None = 0,
		Text = 1,
		Audio = Text << 1,
		Video = Text << 2,
		Photo = Text << 3
	}
}
