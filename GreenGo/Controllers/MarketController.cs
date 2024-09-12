using GreenGo.Repository.Market;
using GreenGo.Repository.UserRebo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GreenGo.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MarketController : ControllerBase
	{
		private readonly IMarketRebo _market;
		public MarketController(IMarketRebo market)
		{
			_market = market;
		}
	}
}
