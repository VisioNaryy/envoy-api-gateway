using TeaApi.Endpoints;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.AddTeaEndpoint();

app.Run();