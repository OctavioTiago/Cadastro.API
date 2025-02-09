    using System;
    using Cadastro.API.Models;

    namespace Cadastro.API.Repository.Produtos;

    public interface IProdutoRepository
    {
        Task<string> CadastrarProduto(Produto produto); 
        Task<IEnumerable<Produto>> ListarProdutos();
    }
