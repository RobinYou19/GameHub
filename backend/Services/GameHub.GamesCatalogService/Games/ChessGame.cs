using GameHub.GamesCatalogService.Abstractions;

namespace GameHub.GamesCatalogService.Games;

public class ChessGame : IGameDefinition
{
    public string Id => "chess";
    public string Name => "Chess";
}