using CoffeeApi.Endpoints;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseHttpsRedirection();

app.AddCoffeeEndpoint();

app.Run();