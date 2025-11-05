var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () => "Cambio en Rama Main Axel");

app.Run();
