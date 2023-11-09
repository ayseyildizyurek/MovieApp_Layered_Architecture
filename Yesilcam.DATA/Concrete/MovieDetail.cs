using System.ComponentModel.DataAnnotations.Schema;

namespace Yesilcam.DATA.Concrete
{
	public class MovieDetail
	{
        public int MovieId { get; set; }
        public bool IsRelease { get; set; }
        public double? Budget { get; set; }
        public double? Revenues { get; set; }

        [Column(TypeName ="text")]
        public string? Details { get; set; }

        //Navigation Prop
        public virtual Movie Movie { get; set; }
    }
}
