using Cadastro.API.Data;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
// Adicionar serviços do Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

string conexao = builder.Configuration.GetConnectionString("DefaultConnection")!;
builder.Services.AddDbContext<AppDataContext>(options => options.UseNpgsql(conexao));

var app = builder.Build();

// Configurar o middleware do Swagger
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Iniciar a aplicação
app.Run();
