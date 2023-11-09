using Yesilcam.DATA.Concrete;
using Yesilcam.REPO.Contexts;
using Yesilcam.REPO.Interfaces;

namespace Yesilcam.REPO.Concrete
{
	public class CategoryREPO : BaseREPO<Category>, ICategoryREPO
	{
		public CategoryREPO(AppDbContext context) : base(context)
		{
		}
	}
}
