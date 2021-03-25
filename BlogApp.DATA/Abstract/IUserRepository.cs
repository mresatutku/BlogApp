using BlogApp.ENTITIES.Concrete;
using BlogApp.SHARED.Data.Abstract;

namespace BlogApp.DATA.Abstract
{
	public interface IUserRepository : IEntityRepository<User>
	{
	}
}