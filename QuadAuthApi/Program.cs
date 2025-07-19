var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers(); // 👈 Add this
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.WebHost.UseUrls("http://0.0.0.0:5000"); // Make app externally accessible

var app = builder.Build();

// Enable Swagger
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Quad Auth API V1");
    c.RoutePrefix = ""; // Swagger at root
});

// Enable routing & controller support
app.UseRouting();
app.MapControllers(); // 👈 Map attribute-routed controllers

app.Run();
