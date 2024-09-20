var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers(); // This adds support for controllers

builder.Services.AddEndpointsApiExplorer(); // Enables OpenAPI
builder.Services.AddSwaggerGen(); // Adds Swagger support

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
