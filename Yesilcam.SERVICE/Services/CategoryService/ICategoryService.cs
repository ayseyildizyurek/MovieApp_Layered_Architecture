using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yesilcam.SERVICE.Models.DTOs;
using Yesilcam.SERVICE.Models.VMs;

namespace Yesilcam.SERVICE.Services.CategoryService
{
	public interface ICategoryService
	{
		int Create(CategoryCreateDTO model);
		int Update(CategoryUpdateDTO model);
		Task<int> Delete(int id);
		Task<CategoryGetVM> GetById(int id);
		//Task<CategoryGetDTO> GetByName(string name);
		Task<List<CategoryGetVM>> GetAll();

	}
}
