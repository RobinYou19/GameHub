using GameHub.GamesCatalogService.Abstractions;

namespace GameHub.GamesCatalogService.Games;

public class Connect4Game : IGameDefinition
{
    public string Id => "connect4";
    public string Name => "Connect 4";
}