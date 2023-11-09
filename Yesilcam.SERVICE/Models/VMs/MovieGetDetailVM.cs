using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yesilcam.SERVICE.Models.VMs
{
	public class MovieGetDetailVM
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Image { get; set; }
		public string Synopsis { get; set; }
		public DateTime? PublishDate { get; set; }
		public int? Duration { get; set; }
		public int CategoryId { get; set; }
		public bool IsRelease { get; set; }
		public double? Budget { get; set; }
		public double? Revenues { get; set; }

		[Column(TypeName = "text")]
		public string? Details { get; set; }
	}
}
