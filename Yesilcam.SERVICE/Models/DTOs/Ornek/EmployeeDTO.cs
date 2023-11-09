using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yesilcam.SERVICE.Models.DTOs.Ornek
{
	public record EmployeeDTO
	{
        public int Id { get; set; }
        public string FullName { get; set; }
    }
}
