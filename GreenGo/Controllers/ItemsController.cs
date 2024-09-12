using GreenGo.Repository.ItemsRebo;
using GreenGo.Repository.Market;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GreenGo.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ItemsController : ControllerBase
	{
		private readonly IItemsRebo _itemsRebo;
		public ItemsController(IItemsRebo itemsRebo)
		{
			_itemsRebo = itemsRebo;
		}
	}
}
