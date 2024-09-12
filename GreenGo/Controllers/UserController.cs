using GreenGo.Repository.Market;
using GreenGo.Repository.UserRebo;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GreenGo.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : ControllerBase
	{
		private readonly IUserRebo _user;
		public UserController(IUserRebo user)
		{
			_user = user;
		}
	}
}
