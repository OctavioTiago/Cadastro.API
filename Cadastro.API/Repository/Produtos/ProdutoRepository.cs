using System;
using Cadastro.API.Data;
using Cadastro.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Cadastro.API.Repository.Produtos;

public class ProdutoRepository (AppDataContext context ) : IProdutoRepository
{
    private readonly AppDataContext context = context;
     public async Task<string> CadastrarProduto(Produto produto)
    {
        await context.TabelaProduto.AddAsync(produto);
        if (await context.SaveChangesAsync() > 0)
        {
         return "Produto cadastrado com sucesso";
        }
        return "Erro: Não conseguimos cadstrar o produto";
    }

    public async Task<IEnumerable<Produto>> ListarProdutos()
    {
        return await context.TabelaProduto.ToListAsync();
    }
}
