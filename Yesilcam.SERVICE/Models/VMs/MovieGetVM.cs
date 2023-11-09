using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yesilcam.SERVICE.Models.VMs
{
	public class MovieGetVM
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Image { get; set; }
		public string Synopsis { get; set; }
		public DateTime? PublishDate { get; set; }
		public int? Duration { get; set; }
		public int CategoryId { get; set; }
	}
}
