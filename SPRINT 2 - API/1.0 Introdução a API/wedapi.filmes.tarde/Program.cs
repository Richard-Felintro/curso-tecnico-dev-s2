var builder = WebApplication.CreateBuilder(args);

//Adiciona o servi�o de Controllers
builder.Services.AddControllers();
var app = builder.Build();

//Mapear os controllers
app.MapControllers();

app.Run();