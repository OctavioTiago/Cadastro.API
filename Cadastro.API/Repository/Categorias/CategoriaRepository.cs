using System;
using Cadastro.API.Data;
using Cadastro.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Cadastro.API.Repository.Categorias;

public class CategoriaRepository(AppDataContext context) : ICategoriaRepository
{
    private readonly AppDataContext context = context; 
    public Task<string> ApagarCategoria(Categoria categoria)
    {
        throw new NotImplementedException();
    }

    public async Task<string> CadastrarCategoria(Categoria categoria)
    {
        await context.TabelaCategoria.AddAsync(categoria);
        if (await context.SaveChangesAsync() > 0)
        {
         return "Categoria cadastrada com sucesso";
        }
        return "Erro: Não conseguimos cadstrar a categoria";
    }
    public Task<string> EditarCategoria(Categoria categoria)
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<Categoria>> ListarCategorias()
    {
        return await context.TabelaCategoria.ToListAsync();
    }

    public Task<Categoria> PesquisarCategoria(int id)
    {
        throw new NotImplementedException();
    }
}
