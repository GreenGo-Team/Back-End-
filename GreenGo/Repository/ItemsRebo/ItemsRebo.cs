using GreenGo.Context;

namespace GreenGo.Repository.ItemsRebo
{
	public class ItemsRebo:IItemsRebo
	{

		private readonly GreenGoDbContext _context;
		public ItemsRebo(GreenGoDbContext context)
		{
			_context = context;
		}
	}
}
