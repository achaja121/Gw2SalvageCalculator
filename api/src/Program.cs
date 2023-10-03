var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(option =>
    {
        option.RouteTemplate = "api/{documentName}/swagger.json";
    });
    app.UseSwaggerUI(option =>
    {
        option.SwaggerEndpoint("/api/v1/swagger.json", "Gw2 Salvage Calculator API");
        option.RoutePrefix = "api/swagger";
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
