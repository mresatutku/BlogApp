using BlogApp.DATA.Abstract;
using BlogApp.ENTITIES.Concrete;
using BlogApp.SHARED.Data.Concrete.EntityFramwork;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.DATA.Concrete.EntityFramework.Repositories
{
	public class UserRepository : EfEntityRepositoryBase<User>, IUserRepository
	{
		public UserRepository(DbContext dbContext) : base(dbContext)
		{
		}
	}
}