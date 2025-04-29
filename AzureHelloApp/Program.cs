var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Simple endpoints
app.MapGet("/", () => "Hello from Azure App Service!");
app.MapGet("/about", () => "This is a sample app deployed to Azure.");

// Health check
app.MapGet("/health", () => "Healthy!");

app.Run();
