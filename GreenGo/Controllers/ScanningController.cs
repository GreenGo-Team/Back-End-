using GreenGo.Repository.Market;
using GreenGo.Repository.ScanningRebo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GreenGo.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ScanningController : ControllerBase
	{
		private readonly IScanningRebo _scanningRebo;
		public ScanningController(IMarketRebo scanningRebo)
		{
			_scanningRebo = scanningRebo;
		}
	}
}
