namespace TheCoach.Web.Models.GetDTO
{
    public class LessonFileDTO
    {
	    public MediaType MediaType { get; set; }

	    public string Name { get; set; }

	    public string Url { get; set; }

	    public LessonDTO Playlist { get; set; }

	    public int Order { get; set; }

	    public string PresentationData { get; set; }
	}
}
