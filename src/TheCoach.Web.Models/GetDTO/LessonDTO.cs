namespace TheCoach.Web.Models.GetDTO
{
	using System.Collections.Generic;

	public class LessonDto
	{
		public long Id { get; set; }

		public string Title { get; set; }

		public string Author { get; set; }

		public string Description { get; set; }

		public decimal Price { get; set; }

		public CategoryDto Category { get; set; }

		public List<LessonFileDto> Lessons { get; set; }
	}
}
