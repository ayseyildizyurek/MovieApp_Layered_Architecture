using Yesilcam.REPO.Concrete;
using Yesilcam.REPO.Contexts;
using Yesilcam.REPO.Interfaces;
using Yesilcam.SERVICE.AutoMappers;
using Yesilcam.SERVICE.Services.CategoryService;
using Yesilcam.SERVICE.Services.CommentService;
using Yesilcam.SERVICE.Services.MovieService;

namespace Yesilcam.UI
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);
			builder.Services.AddControllersWithViews();

			//EntityService
			builder.Services.AddDbContext<AppDbContext>();

			//Automapper Service

			builder.Services.AddAutoMapper(typeof(Mapping));

			//Repolarý da ayaðý kaldýrmak gerekli

			builder.Services.AddScoped<IActorREPO, ActorREPO>();
			builder.Services.AddScoped<ICategoryREPO, CategoryREPO>();
			builder.Services.AddScoped<ICommentREPO, CommentREPO>();
			builder.Services.AddScoped<IMovieActorREPO, MovieActorREPO>();
			builder.Services.AddScoped<IMovieDetailREPO, MovieDetailREPO>();
			builder.Services.AddScoped<IMovieREPO, MovieREPO>();


			//my services

			builder.Services.AddScoped<ICategoryService, CategoryService>();
			builder.Services.AddScoped<ICommentService, CommentService>();
			builder.Services.AddScoped<IMovieService, MovieService>();


			var app = builder.Build();

			
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();
			app.UseAuthentication();
			app.UseAuthorization();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}");

			app.Run();
		}
	}
}