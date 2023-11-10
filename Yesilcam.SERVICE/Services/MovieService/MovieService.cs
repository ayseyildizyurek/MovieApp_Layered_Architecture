using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yesilcam.DATA.Concrete;
using Yesilcam.DATA.Enums;
using Yesilcam.REPO.Concrete;
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
			var movies = await _movieREPO.GetAll(x => x.Status != Status.Passive);
			return _mapper.Map<List<MovieGetVM>>(movies);
		}

		public async Task<List<MovieGetVM>> GetAllByCatId(int id)
		{
			var movies =await _movieREPO.GetAll(x => x.CategoryId == id);
			return _mapper.Map<List<MovieGetVM>>(movies);
		}

		public async Task<MovieGetVM> GetById(int id)
		{
			//null kontrolü yapılabilir
			var movie=await _movieREPO.GetById(id);
			return _mapper.Map<MovieGetVM>(movie);
		}

		public async Task<MovieGetDetailVM> GetMovieDetailById(int id)
		{
			var movie=await _movieREPO.GetFilteredFirstOrDefault(
				select:x=>new MovieGetDetailVM
				{
					Id = x.Id,
					Name = x.Name,
					Image=x.Image,
					Synopsis = x.Synopsis,
					PublishDate = x.PublishDate,
					Duration = x.Duration,
					CategoryId = x.CategoryId,
					MovieDetail=_mapper.Map<MovieGetOnlyDetailVM>(x.MovieDetail)
				},
				where:x=>x.Status!=Status.Passive && x.Id==id,
				join: x=>x.Include(y=>y.MovieDetail));
			return movie;
		}

		public int Update(MovieCreateDTO model)
		{
			return _movieREPO.Update(_mapper.Map<Movie>(model));
		}
	}
}
