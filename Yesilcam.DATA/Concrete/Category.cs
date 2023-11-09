using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Yesilcam.DATA.Abstract;
using Yesilcam.DATA.HelperClasses;

namespace Yesilcam.DATA.Concrete
{
	public class Category:BaseMovie
	{
        [Required]
        [Column(TypeName ="nvarchar(50)")]
        public string Name { get; set; }

		[NotMapped]
		public string NormalizedName 
		{
			get
			{
				return Normalized.TurkishToEnglish(Name);
			}
		}

        //Navgation Property
        public virtual IList<Movie> Movies { get; set; }
    }
}
