using GreenGo.Context;

namespace GreenGo.Repository.UserRebo
{
	public class UserRebo:IUserRebo
	{
		private readonly GreenGoDbContext _context;
		public UserRebo(GreenGoDbContext context)
		{
			_context = context;
		}
	}
}
