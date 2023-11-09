using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yesilcam.DATA.Abstract;

namespace Yesilcam.DATA.Concrete
{
	public class Actor:BaseMovie
	{
        [Column(TypeName ="nvarchar(50)")]
        public string FirstName { get; set; }
		[Column(TypeName = "nvarchar(50)")]
		public string LastName { get; set; }
        public DateTime? BirthDate { get; set; }
		[Column(TypeName = "nvarchar(50)")]
		public string Biography { get; set; }

        //Navigation prop
        public virtual IList<MovieActor> MovieActors { get; set; }
    }
}
