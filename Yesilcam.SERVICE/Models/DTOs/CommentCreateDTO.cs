using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yesilcam.SERVICE.Models.DTOs
{
	public class CommentCreateDTO
	{
		public int MovieId { get; set; }
		public string AppUserId { get; set; }
		public string Content { get; set; }
	}
}
