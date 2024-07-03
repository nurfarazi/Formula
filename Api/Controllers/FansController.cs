using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FansController : ControllerBase
{
    public FansController()
    {
    }

    [HttpGet]
    public IActionResult GetAsync()
    {
        return Ok("Fans");
    }

    [HttpGet("{id}")]
    public IActionResult GetByIdAsync(int id)
    {
        return Ok($"Fans {id}");
    }

    [HttpPost]
    public IActionResult PostAsync()
    {
        return Ok("Fans");
    }

    [HttpPut("{id}")]
    public IActionResult PutAsync(int id)
    {
        return Ok($"Fans {id}");
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteAsync(int id)
    {
        return Ok($"Fans {id}");
    }
}