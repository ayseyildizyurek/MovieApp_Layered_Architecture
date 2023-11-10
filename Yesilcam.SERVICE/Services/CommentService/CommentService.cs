using AutoMapper;
using Yesilcam.DATA.Concrete;
using Yesilcam.DATA.Enums;
using Yesilcam.REPO.Interfaces;
using Yesilcam.SERVICE.Models.DTOs;
using Yesilcam.SERVICE.Models.VMs;

namespace Yesilcam.SERVICE.Services.CommentService
{
	public class CommentService:ICommentService
	{
		private readonly ICommentREPO _commentREPO;

		private readonly IMapper _mapper;

		public CommentService(ICommentREPO commentREPO, IMapper mapper)
		{
			_commentREPO = commentREPO;
			_mapper = mapper;
		}

		public int Create(CommentCreateDTO model)
		{
			var comment = _mapper.Map<Comment>(model);
			comment.Status = Status.Passive;
			return _commentREPO.Create(comment);
		}

		public async Task<int> Delete(int id)
		{
			var comment = await _commentREPO.GetById(id);
			if (comment != null)
			{
				comment.Status = Status.Passive;
				comment.PassiveDate = DateTime.Now;
				return _commentREPO.Delete(comment);
			}
			return 0;
		}

		public async Task<List<CommentGetVM>> GetAll()
		{
			var comments = await _commentREPO.GetAll(x => x.Id > 0);
			return _mapper.Map<List<CommentGetVM>>(comments);
		}

		public async Task<List<CommentGetVM>> GetAllByMoiveId(int id)
		{
			var comments = await _commentREPO.GetAll(x => x.MovieId == id);
			return _mapper.Map<List<CommentGetVM>>(comments);
		}

		public async Task<CommentGetVM> GetById(int id)
		{
			var comment = await _commentREPO.GetById(id);
			return _mapper.Map<CommentGetVM>(comment);
		}

		public async Task<int> Update(int id)
		{
			var comment = await _commentREPO.GetById(id);
			if (comment != null)
			{
				if (comment.Status == Status.Active)
				{
					comment.Status = Status.Passive;
					comment.PassiveDate = DateTime.Now;
					return _commentREPO.Create(comment);
				}

				else
				{
					comment.Status = Status.Modified;

					comment.UpdateDate = DateTime.Now;

					return _commentREPO.Create(comment);
				}
			}
			return 0;
		}
	}
}
