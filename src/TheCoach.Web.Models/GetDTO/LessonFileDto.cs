namespace TheCoach.Web.Models.GetDTO
{
	using TheCoach.Web.Models.Discriminators;

	public class LessonFileDto
	{
		public long Id { get; set; }

		public MediaType MediaType { get; set; }

		public string Title { get; set; }

		public string Url { get; set; }

		public LessonDto Playlist { get; set; }

		public int Order { get; set; }

		public float Speed { get; set; }
	}
}
