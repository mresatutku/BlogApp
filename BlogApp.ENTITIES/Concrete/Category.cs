using System.Collections.Generic;
using BlogApp.SHARED.Entities.Abstract;

namespace BlogApp.ENTITIES.Concrete
{
	public class Category : EntityBase, IEntity
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public ICollection<Article> Articles { get; set; }
	}
}