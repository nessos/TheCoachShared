namespace TheCoach.Web.Models.GetDTO
{
	using TheCoach.Web.Models.Discriminators;

	public class LessonFileDto
	{
		public long Id { get; set; }

		public long ParentLessonFileId { get; set; }

		public MediaType MediaType { get; set; }

		public string Title { get; set; }

		public string Description { get; set; }

		public string Url { get; set; }

		public string Language { get; set; }

		public int Order { get; set; }

		public int Repeat { get; set; }

		public float Speed { get; set; }

		public bool IsUploaded { get; set; }

		public bool IsFolder { get; set; }
	}
}
