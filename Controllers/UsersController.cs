using Microsoft.AspNetCore.Mvc;

namespace MoreApi.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
	[HttpGet]
	public IActionResult Get()
	{
		return Ok(new
		{
			FirstName = "John",
			LastName = "Doe",
			Age = 30,
			Environment = Environment.GetEnvironmentVariable("star")
		});
	}
}
