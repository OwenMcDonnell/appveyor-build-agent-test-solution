var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello from the C# web project.");
app.MapGet("/health", () => Results.Ok(new { status = "ok", language = "C#" }));

app.Run();
