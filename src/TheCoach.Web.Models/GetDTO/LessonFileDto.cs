namespace TheCoach.Web.Models.GetDTO
{
	public class LessonFileDto
	{
		public long Id { get; set; }

		public MediaType MediaType { get; set; }

		public string Name { get; set; }

		public string Url { get; set; }

		public LessonDto Playlist { get; set; }

		public int Order { get; set; }

		public float Speed { get; set; }
	}
}
