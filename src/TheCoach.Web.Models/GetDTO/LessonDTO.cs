namespace TheCoach.Web.Models.GetDTO
{
	public class LessonDTO
	{
		public string Title { get; set; }

		public string Author { get; set; }

		public string Description { get; set; }

		public decimal Price { get; set; }

		public CategoryGetDTO Category { get; set; }
	}
}
