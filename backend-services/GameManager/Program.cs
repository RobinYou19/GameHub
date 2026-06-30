var builder = WebApplication.CreateBuilder(args);

// Permettre au Frontend React d'appeler l'API (Gestion du CORS)
builder.Services.AddCors(options => {
    options.AddDefaultPolicy(policy => policy.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

var app = builder.Build();

app.UseCors();

// Notre endpoint pour le Frontend
app.MapGet("/api/games", () => new[] {
    new { Id = "tic-tac-toe", Name = "Morpion", Status = "Ready" },
    new { Id = "snake", Name = "Snake", Status = "In Progress" },
    new { Id = "chess", Name = "Chess", Status = "To Do" }
});

app.Run();