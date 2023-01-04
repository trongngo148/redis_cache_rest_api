using Microsoft.AspNetCore.Mvc;

namespace CacheRESTApiWithRedis.Controllers;

[Route("api/[controller]")]
public class TestController : Controller
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Hihi");
    }
}