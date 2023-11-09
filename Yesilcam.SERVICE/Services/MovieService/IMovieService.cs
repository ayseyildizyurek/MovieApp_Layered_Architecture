using Yesilcam.SERVICE.Models.DTOs;
using Yesilcam.SERVICE.Models.VMs;

namespace Yesilcam.SERVICE.Services.MovieService
{
	public interface IMovieService
	{
		int Create(MovieCreateDTO model);
		int Update(MovieCreateDTO model);
		Task<int> Delete(int id);

		Task<MovieGetVM> GetById(int id);
		Task<List<MovieGetVM>> GetAll();
		Task<List<MovieGetVM>> GetAllByCatId(int id);
		Task<MovieGetDetailVM> GetMovieDetailById(int id);

	}
}
