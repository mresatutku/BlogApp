using BlogApp.DATA.Abstract;
using BlogApp.ENTITIES.Concrete;
using BlogApp.SHARED.Data.Concrete.EntityFramwork;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.DATA.Concrete.EntityFramework.Repositories
{
	public class RoleRepository : EfEntityRepositoryBase<Role>, IRoleRepository
	{
		public RoleRepository(DbContext dbContext) : base(dbContext)
		{
		}
	}
}