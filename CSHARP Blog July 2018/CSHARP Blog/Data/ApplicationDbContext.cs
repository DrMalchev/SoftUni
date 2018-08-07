using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CSHARP_Blog.Models;

namespace CSHARP_Blog.Data
{
    public class BlogDbContext : IdentityDbContext<User>
    {
        public BlogDbContext(DbContextOptions<BlogDbContext> options)
            : base(options) 
			{
			this.Database.EnsureCreated();
			}

		public DbSet<Article> Articles { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.Entity<Article>().HasOne(a => a.Author).WithMany(u => u.Articles).HasForeignKey(a=>a.AuthorId);

			base.OnModelCreating(builder);
		}
	}
}
