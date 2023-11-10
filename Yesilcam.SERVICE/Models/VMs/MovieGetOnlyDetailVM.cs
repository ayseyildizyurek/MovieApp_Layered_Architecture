using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yesilcam.SERVICE.Models.VMs
{
	public class MovieGetOnlyDetailVM
	{
        public int MovieId { get; set; }
		public bool IsRelease { get; set; }
		public double? Budget { get; set; }
		public double? Revenues { get; set; }
		public string? Details { get; set; }
	}
}
