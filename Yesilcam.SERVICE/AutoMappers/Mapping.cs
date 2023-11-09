using AutoMapper;
using Yesilcam.DATA.Concrete;
using Yesilcam.SERVICE.Models.DTOs;
using Yesilcam.SERVICE.Models.DTOs.Ornek;
using Yesilcam.SERVICE.Models.VMs;

namespace Yesilcam.SERVICE.AutoMappers
{
	public class Mapping:Profile
	{
        public Mapping()
        {
			//Category sınıfı ile CategoryCreateDTO yu eşleştirelim, eşleştirme propisimleriyle yapılır bu nedenle isimlerin aynı olması gereklidir.
			//ReverseMap dediğimizde categoryi dto ya, dtoyu da categorye çevirebilir. Demezsek ilk paramatreyi yani categoryi ikinci paramatreye yani dto ya çevirirdi. ReverseMap demeseydik tekrardan  CreateMap<CategoryCreateDTO, Category>() diyebilirdik.
			//CreateMap<Category, CategoryCreateDTO>().ReverseMap();

			////ForMember: özellikle isim farklılıklarından dolayı veya veya özel dönüşüme ihtiyaç olduğu durumlarda kullanılır. 

			//CreateMap<Employee, EmployeeDTO>().ForMember(dest=>dest.FullName,opt=>opt.MapFrom(src=>src.EmpFirstName+" "+src.EmpLastName));

			CreateMap<Category, CategoryCreateDTO>().ReverseMap();
			CreateMap<Category, CategoryUpdateDTO>().ReverseMap();
			CreateMap<Category, CategoryGetVM>();

			CreateMap<Movie, MovieCreateDTO>().ReverseMap();
			CreateMap<Movie, MovieGetVM>().ReverseMap();
		}
    }
}
