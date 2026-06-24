using GameHub.GamesCatalogService.Abstractions;

namespace GameHub.GamesCatalogService.Services;

public interface IGameProvider
{
    IEnumerable<IGameDefinition> GetGames();
}