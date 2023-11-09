using Microsoft.AspNetCore.Identity;

namespace Yesilcam.DATA.Concrete
{
	public class AppUser:IdentityUser
	{
		//Nav prop
		public virtual List<Comment> Comments { get; set; }
	}
}
