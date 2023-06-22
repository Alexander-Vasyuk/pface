using Microsoft.AspNetCore.Mvc;
using pokerface.Models;

namespace pokerface.Controllers;
[ApiController]
[Route("[controller]")]
public class PlayerController : ControllerBase
{
	//public PlayerController(ILogger<PlayerController> logger)
	//{
	//	_logger = logger;
	//}

	[HttpGet]
	public IEnumerable<Player> Get()
	{
		return new[]
		{
			new Player() { Name = "Player 1" },
			new Player() { Name = "Player 2" },
			new Player() { Name = "Player 3" }
		};
	}
}
