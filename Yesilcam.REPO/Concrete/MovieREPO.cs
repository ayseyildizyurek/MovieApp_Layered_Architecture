using Yesilcam.DATA.Concrete;
using Yesilcam.REPO.Contexts;
using Yesilcam.REPO.Interfaces;

namespace Yesilcam.REPO.Concrete
{
	public class MovieREPO : BaseREPO<Movie>, IMovieREPO
	{
		public MovieREPO(AppDbContext context) : base(context)
		{
		}
	}
}
