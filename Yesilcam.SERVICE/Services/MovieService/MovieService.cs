using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yesilcam.DATA.Concrete;
using Yesilcam.DATA.Enums;
using Yesilcam.REPO.Interfaces;
using Yesilcam.SERVICE.Models.DTOs;
using Yesilcam.SERVICE.Models.VMs;

namespace Yesilcam.SERVICE.Services.MovieService
{
	public class MovieService : IMovieService
	{
		private readonly IMovieREPO _movieREPO;
		private readonly IMapper _mapper;

		public MovieService(IMovieREPO movieREPO, IMapper mapper)
		{
			_movieREPO = movieREPO;
			_mapper = mapper;
		}

		public int Create(MovieCreateDTO model)
		{
			return _movieREPO.Create(_mapper.Map<Movie>(model));
		}

		public async Task<int> Delete(int id)
		{
			var movie = await _movieREPO.GetById(id);
			if (movie != null)
			{
				movie.PassiveDate = DateTime.Now;
				movie.Status = Status.Passive;
				return _movieREPO.Delete(movie);
			}
			return 0;
		}

		public async Task<List<MovieGetVM>> GetAll()
		{
			return await _movieREPO.GetAll(x => _mapper.Map<MovieGetVM>(x));
		}

		public Task<List<MovieGetVM>> GetAllByCatId(int id)
		{
			throw new NotImplementedException();
		}

		public Task<MovieGetVM> GetById(int id)
		{
			throw new NotImplementedException();
		}

		public Task<MovieGetDetailVM> GetMovieDetailById(int id)
		{
			throw new NotImplementedException();
		}

		public int Update(MovieCreateDTO model)
		{
			throw new NotImplementedException();
		}
	}
}
