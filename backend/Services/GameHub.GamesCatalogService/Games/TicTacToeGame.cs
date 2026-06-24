using GameHub.GamesCatalogService.Abstractions;

namespace GameHub.GamesCatalogService.Games;

public class TicTacToeGame : IGameDefinition
{
    public string Id => "tictactoe";
    public string Name => "Tic Tac Toe";
}