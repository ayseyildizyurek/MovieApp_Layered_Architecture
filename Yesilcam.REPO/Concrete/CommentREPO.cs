using Yesilcam.DATA.Concrete;
using Yesilcam.REPO.Contexts;
using Yesilcam.REPO.Interfaces;

namespace Yesilcam.REPO.Concrete
{
	public class CommentREPO : BaseREPO<Comment>, ICommentREPO
	{
		public CommentREPO(AppDbContext context) : base(context)
		{
		}
	}
}
