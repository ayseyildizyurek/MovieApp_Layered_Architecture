using Yesilcam.DATA.Abstract;

namespace Yesilcam.DATA.Concrete
{
	public class MovieActor:BaseMovie
	{
        public int ActorId { get; set; }
        public int MovieId { get; set; }

        //nav prop
        public virtual Actor Actor { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
