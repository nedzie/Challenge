var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddSwaggerGen(); // Add required functionality for Swagger generation

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger(); // Register the Swagger middleware
    app.UseSwaggerUI(); // Register the Swagger UI middleware (/swagger/index.html)
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
