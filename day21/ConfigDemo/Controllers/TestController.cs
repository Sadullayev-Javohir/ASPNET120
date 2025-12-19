using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using ConfigDemo.Models;

[ApiController]
[Route("api/[controller]")]
public class TestController : Controller
{
  private readonly MySettings _options;
  private readonly MySettings _snapshot;
  private readonly MySettings _monitor;

  public TestController(
    IOptions<MySettings> options,
    IOptionsSnapshot<MySettings> snapshot,
    IOptionsMonitor<MySettings> monitor
  )
  {
    _options = options.Value;
    _snapshot = snapshot.Value;
    _monitor = monitor.CurrentValue;
  }

  [HttpGet]
  public IActionResult Get()
  {
    return Ok(new
    {
      Options = _options.LevelName,
      Snapshot = _snapshot.LevelName,
      Monitor = _monitor.LevelName
    });
  }
}
