using Yesilcam.DATA.Concrete;
using Yesilcam.REPO.Contexts;
using Yesilcam.REPO.Interfaces;

namespace Yesilcam.REPO.Concrete
{
	public class MovieDetailREPO : BaseREPO<MovieDetail>, IMovieDetailREPO
	{
		public MovieDetailREPO(AppDbContext context) : base(context)
		{
		}
	}
}
