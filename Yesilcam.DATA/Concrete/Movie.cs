using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Yesilcam.DATA.Abstract;
using Yesilcam.DATA.HelperClasses;

namespace Yesilcam.DATA.Concrete
{
	public class Movie:BaseMovie
	{
		[Required]
		[Column(TypeName = "nvarchar(50)")]
		public string Name { get; set; }

		[NotMapped]
		public string NormalizedName
		{
			get
			{
				return Normalized.TurkishToEnglish(Name);
			}
		}

		[Column(TypeName = "nvarchar(50)")]
		public string Image { get; set; }

		[Column(TypeName = "nvarchar(150)")]
		public string Synopsis { get; set; }

		public DateTime? PublishDate { get; set; }
        public int? Duration { get; set; }

		//Navigation Prop

		public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual MovieDetail MovieDetail { get; set; }
        public virtual IList<MovieActor> MovieActors { get; set; }
        public virtual IList<Comment> Comments { get; set; }
    }
}
