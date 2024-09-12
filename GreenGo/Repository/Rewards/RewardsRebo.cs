using GreenGo.Context;

namespace GreenGo.Repository.Rewards
{
	public class RewardsRebo:IRewardsRebo
	{
		private readonly GreenGoDbContext _context;
		public RewardsRebo(GreenGoDbContext context)
		{
			_context = context;
		}
	}
}
