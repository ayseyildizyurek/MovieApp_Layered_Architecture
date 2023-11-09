using System.ComponentModel.DataAnnotations.Schema;
using Yesilcam.DATA.Abstract;

namespace Yesilcam.DATA.Concrete
{
	public class Comment : BaseMovie
	{
		public int MovieId { get; set; }
		public string AppUserId { get; set; }

		[Column(TypeName = "nvarchar(150)")]
		public string Content { get; set; }

		//navigation prop

		public virtual Movie Movie { get; set; }

		public virtual AppUser AppUser { get; set; }
	}
}
