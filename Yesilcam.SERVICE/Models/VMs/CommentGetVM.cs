using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yesilcam.SERVICE.Models.VMs
{
	public class CommentGetVM
	{
		public string Content { get; set; }
		public DateTime CommentDate { get; set; }
		public string User { get; set; }
	}
}
