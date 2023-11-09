using Yesilcam.DATA.Enums;

namespace Yesilcam.DATA.Abstract
{
	public abstract class BaseMovie
	{
        public int Id { get; set; }
        public DateTime ActiveDate { get; set; } = DateTime.Now;
        public DateTime? PassiveDate { get; set; }
		public DateTime? UpdateDate { get; set; }
        public Status Status { get; set; } = Status.Active;
    }
}
