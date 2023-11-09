namespace Yesilcam.SERVICE.Models.DTOs
{
	public class MovieCreateDTO
	{
		public string Name { get; set; }
		public string Image { get; set; }
		public string Synopsis { get; set; }

		public DateTime? PublishDate { get; set; }
		public int? Duration { get; set; }
		public int CategoryId { get; set; }
	}
}
