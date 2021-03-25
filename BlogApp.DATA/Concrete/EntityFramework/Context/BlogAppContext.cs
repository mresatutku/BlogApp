using BlogApp.ENTITIES.Concrete;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.DATA.Concrete.EntityFramework.Context
{
	public class BlogAppContext : DbContext
	{
		public DbSet<Article> Articles { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Comment> Comments { get; set; }
		public DbSet<Role> Roles { get; set; }
		public DbSet<User> Users { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(
				@"VAIO\SQLEXPRESS; Database=BlogAppDB Trusted_Connection=True; Connect Timeout=30; MultipleActiveResultSets=True;");
		}
	}
}