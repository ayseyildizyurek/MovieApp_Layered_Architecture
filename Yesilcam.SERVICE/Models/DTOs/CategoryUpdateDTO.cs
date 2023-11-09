using Yesilcam.DATA.Enums;

namespace Yesilcam.SERVICE.Models.DTOs
{
	public class CategoryUpdateDTO
	{
		public string Name { get; set; }
        public DateTime UpdateDate { get; set; }=DateTime.Now;
		public Status Status { get; set; } = Status.Modified;
    }
}
