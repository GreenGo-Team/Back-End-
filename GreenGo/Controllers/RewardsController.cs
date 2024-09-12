using GreenGo.Repository.Market;
using GreenGo.Repository.Rewards;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GreenGo.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class RewardsController : ControllerBase
	{
		private readonly IRewardsRebo _rewards;
		public RewardsController(IRewardsRebo rewards)
		{
			_rewards = rewards;
		}
	}
}
