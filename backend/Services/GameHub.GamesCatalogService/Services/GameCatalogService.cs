using GameHub.GamesCatalogService.Abstractions;

namespace GameHub.GamesCatalogService.Services;

public class GameCatalogService : IGameCatalogService
{
    private readonly IGameProvider _provider;

    public GameCatalogService(IGameProvider provider)
    {
        _provider = provider;
    }

    public IEnumerable<IGameDefinition> GetGames()
        => _provider.GetGames();
}