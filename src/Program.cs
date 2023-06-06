using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Nome da API V1");
});

app.MapGet("/", () => "Buenos dias");


app.Run();
