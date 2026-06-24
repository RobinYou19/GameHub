using GameHub.GamesCatalogService.Abstractions;

namespace GameHub.GamesCatalogService.Services;

public interface IGameCatalogService
{
    IEnumerable<IGameDefinition> GetGames();
}