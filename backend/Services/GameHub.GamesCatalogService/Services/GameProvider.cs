using GameHub.GamesCatalogService.Abstractions;

namespace GameHub.GamesCatalogService.Services;

public class GameProvider : IGameProvider
{
    private readonly IEnumerable<IGameDefinition> _games;

    public GameProvider(IEnumerable<IGameDefinition> games)
    {
        _games = games;
    }

    public IEnumerable<IGameDefinition> GetGames()
        => _games;
}