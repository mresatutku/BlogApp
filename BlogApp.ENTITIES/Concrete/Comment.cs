using BlogApp.SHARED.Entities.Abstract;

namespace BlogApp.ENTITIES.Concrete
{
	public class Comment : EntityBase, IEntity
	{
		public string Text { get; set; }
		public int ArticleId { get; set; }
		public Article Article { get; set; }
	}
}