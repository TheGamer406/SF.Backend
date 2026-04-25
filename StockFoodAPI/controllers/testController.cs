using Microsoft.AspNetCore.Mvc;

namespace StockFoodAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TestController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            status = "online",
            message = "StockFood API is running!",
            timestamp = DateTime.UtcNow
        });
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        return Ok(new
        {
            id = id,
            message = $"Item {id} found",
            timestamp = DateTime.UtcNow
        });
    }

    [HttpPost]
    public IActionResult Post([FromBody] TestRequest request)
    {
        return Ok(new
        {
            received = request,
            message = "Data received successfully",
            timestamp = DateTime.UtcNow
        });
    }
}

public record TestRequest(string Name, string Description);