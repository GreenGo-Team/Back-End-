using GreenGo.Context;

namespace GreenGo.Repository.Market
{
	public class MarketRebo:IMarketRebo
	{
		private readonly GreenGoDbContext _context;
		public MarketRebo(GreenGoDbContext context)
		{
			_context = context;
		}
	}
}
