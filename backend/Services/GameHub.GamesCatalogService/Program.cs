using GameHub.GamesCatalogService.Abstractions;
using GameHub.GamesCatalogService.Games;
using GameHub.GamesCatalogService.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();


// 🔑 Strategy pattern registration
builder.Services.AddSingleton<IGameDefinition, ChessGame>();
builder.Services.AddSingleton<IGameDefinition, Connect4Game>();
builder.Services.AddSingleton<IGameDefinition, TicTacToeGame>();

builder.Services.AddSingleton<IGameProvider, GameProvider>();
builder.Services.AddSingleton<IGameCatalogService, GameCatalogService>();

var app = builder.Build();

app.UseHttpsRedirection();
app.MapControllers();
app.Run();