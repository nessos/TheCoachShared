using System.Collections.Generic;

namespace TheCoach.Web.Models.GetDTO
{
	public class FileSystemEntryModel
	{
		public string Path { get; set; }

		public string Name { get; set; }

		public bool IsDirectory { get; set; }
	}
}
