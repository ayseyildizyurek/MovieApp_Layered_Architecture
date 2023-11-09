using AutoMapper;
using Yesilcam.DATA.Concrete;
using Yesilcam.DATA.Enums;
using Yesilcam.REPO.Interfaces;
using Yesilcam.SERVICE.Models.DTOs;
using Yesilcam.SERVICE.Models.VMs;

namespace Yesilcam.SERVICE.Services.CategoryService
{
	public class CategoryService : ICategoryService
	{
		private readonly ICategoryREPO _categoryREPO;
		private readonly IMapper _mapper;

		public CategoryService(ICategoryREPO categoryREPO)
		{
			_categoryREPO = categoryREPO;
		}

		public int Create(CategoryCreateDTO model)
		{
			var category = _mapper.Map<Category>(model);
			return _categoryREPO.Create(category);
		}

		public async Task<int> Delete(int id)
		{
			var category = await _categoryREPO.GetById(id);
			if (category != null)
			{
				category.PassiveDate = DateTime.Now;
				category.Status = Status.Passive;
				return _categoryREPO.Delete(category);
			}
			return 0;
		}

		public async Task<List<CategoryGetVM>> GetAll()
		{
			var categories = await _categoryREPO.GetFilteredList(
				select: x => new CategoryGetVM { Id = x.Id, Name = x.Name },
				where: x => x.Status != Status.Passive,
				orderBy: x => x.OrderBy(x => x.Name));

			return categories;
		}

		public async Task<CategoryGetVM> GetById(int id)
		{
			var category = await _categoryREPO.GetById(id);
			return _mapper.Map<CategoryGetVM>(category);
		}

		public int Update(CategoryUpdateDTO model)
		{
			return _categoryREPO.Update(_mapper.Map<Category>(model));
		}
	}
}
