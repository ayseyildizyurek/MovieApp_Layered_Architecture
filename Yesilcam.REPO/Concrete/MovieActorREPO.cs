using Yesilcam.DATA.Concrete;
using Yesilcam.REPO.Contexts;
using Yesilcam.REPO.Interfaces;

namespace Yesilcam.REPO.Concrete
{
	public class MovieActorREPO : BaseREPO<MovieActor>, IMovieActorREPO
	{
		public MovieActorREPO(AppDbContext context) : base(context)
		{
		}
	}
}
