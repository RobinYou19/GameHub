// Controllers/GamesController.cs

using GameHub.GamesCatalogService.Services;
using Microsoft.AspNetCore.Mvc;

namespace GameHub.GamesCatalogService.Controllers;

[ApiController]
[Route("games")]
public class GamesController : ControllerBase
{
    private readonly IGameProvider _service;

    public GamesController(IGameProvider service)
    {
        _service = service;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_service.GetGames());
    }
}