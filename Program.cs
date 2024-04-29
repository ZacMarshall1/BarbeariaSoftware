using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSwaggerGen();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<BarbeariaContext>();
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();
app.MapGet("/", () => "Barbearia API");
app.MapFuncionarioApi();
app.MapClienteApi();
app.MapAgendamentoApi();
app.MapServicoApi();

app.Run();

