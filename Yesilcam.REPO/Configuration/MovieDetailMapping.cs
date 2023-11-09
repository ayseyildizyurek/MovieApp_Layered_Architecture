using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yesilcam.DATA.Concrete;

namespace Yesilcam.REPO.Configuration
{
	public class MovieDetailMapping : IEntityTypeConfiguration<MovieDetail>
	{
		public void Configure(EntityTypeBuilder<MovieDetail> builder)
		{
			builder.HasKey(x => x.MovieId);
			builder.HasOne(x => x.Movie).WithOne(x => x.MovieDetail).HasForeignKey<MovieDetail>(x => x.MovieId);
		}
	}
}
