using System;
using Cadastro.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Cadastro.API.Data;

public class AppDataContext : DbContext
{
    public AppDataContext(DbContextOptions<AppDataContext> options) : base(options) {}

    public required DbSet<Categoria> TabelaCategoria { get; set; }

    public required DbSet<Produto> TabelaProduto { get; set; }
}
