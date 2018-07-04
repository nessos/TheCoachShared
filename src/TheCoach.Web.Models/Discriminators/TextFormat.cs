namespace TheCoach.Web.Models.Discriminators
{
	public enum TextFormat
	{
		None = 0,
		PlainText = 1,
		Pdf = PlainText << 1,
		Docx = PlainText << 2
	}
}
