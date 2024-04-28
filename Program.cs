using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<BarbeariaContext>(options => options.UseInMemoryDatabase("tarefas"));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

var app = builder.Build();