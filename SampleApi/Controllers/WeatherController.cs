using Microsoft.AspNetCore.Mvc;
using SampleApi.Models;

namespace SampleApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class WeatherController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new { Message = "API is running", Time = DateTime.UtcNow });
    }

    [HttpPost]
    public IActionResult Post([FromBody] WeatherRequest request)
    {
        return Ok(new { Message = "Data received", Data = request });
    }
}
