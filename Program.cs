using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddDbContext<BarbeariaContext>();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

var app = builder.Build();
app.MapGet("/", () => "Barbearia API");
app.MapFuncionarioApi();
app.MapClienteApi();
app.MapAgendamentoApi();
app.MapServicoApi();

app.Run();

