using Yesilcam.DATA.Concrete;
using Yesilcam.REPO.Contexts;
using Yesilcam.REPO.Interfaces;

namespace Yesilcam.REPO.Concrete
{
	public class ActorREPO : BaseREPO<Actor>, IActorREPO
	{
		public ActorREPO(AppDbContext context) : base(context)
		{
		}
	}
}
