using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yesilcam.SERVICE.Models.DTOs;
using Yesilcam.SERVICE.Models.VMs;

namespace Yesilcam.SERVICE.Services.CommentService
{
	public interface ICommentService
	{
		int Create(CommentCreateDTO model);
		Task<int> Update(int id);
		Task<int> Delete(int id);
		Task<CommentGetVM> GetById(int id);
		Task<List<CommentGetVM>> GetAll();
		Task<List<CommentGetVM>> GetAllByMoiveId(int id);
	}
}
