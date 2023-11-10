
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Yesilcam.DATA.Concrete;
using Yesilcam.REPO.Configuration;

namespace Yesilcam.REPO.Contexts
{
	public class AppDbContext : IdentityDbContext
	{
		public DbSet<Actor> Actors { get; set; }
		public DbSet<AppUser> AppUsers { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Comment> Comments { get; set; }
		public DbSet<Movie> Movies { get; set; }
		public DbSet<MovieActor> MovieActors { get; set; }
		public DbSet<MovieDetail> MovieDetails { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			
			optionsBuilder.UseSqlServer("Data Source=DESKTOP-8JB5AHL\\SQLEXPRESS;Initial Catalog=YesilcamMovieApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
			builder.ApplyConfiguration(new MovieDetailMapping());
		}
	}
}
