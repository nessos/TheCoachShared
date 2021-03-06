namespace TheCoach.Web.Models.GetDTO
{
	using System.Collections.Generic;

	public class LessonDto
	{
		public long Id { get; set; }

		public int Order { get; set; }

		public string Title { get; set; }

		public string Author { get; set; }

		public string Description { get; set; }

		public decimal Price { get; set; }

		public int Repeat { get; set; }

		public double SizeMB { get; set; }

		public string WallpaperUrl { get; set; }

		public string IntroVideoUrl { get; set; }

		public CorporationDto Corporation { get; set; }

		public CategoryDto Category { get; set; }

		public List<LessonFileDto> LessonFiles { get; set; }

		public string GooglePlayProductId { get; set; }
		public string AppStoreProductId { get; set; }

		public bool IsBundle { get; set; }
		public string BundleLessonsGooglePlayProductIds { get; set; }
		public string BundleLessonsAppStoreProductIds { get; set; }

		public bool Purchased { get; set; }
	}
}
