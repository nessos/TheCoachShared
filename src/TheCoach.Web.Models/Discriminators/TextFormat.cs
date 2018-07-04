namespace TheCoach.Web.Models.Discriminators
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum TextFormat
	{
		None = 0,
		PlainText = 1,
		Pdf = PlainText << 1,
		Docx = PlainText << 2
	}
}
