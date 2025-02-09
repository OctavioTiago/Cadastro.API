using System;
using Cadastro.API.Models;

namespace Cadastro.API.Repository.Categorias;

public interface ICategoriaRepository
{
    Task<string> CadastrarCategoria(Categoria categoria);
    Task<IEnumerable<Categoria>> ListarCategorias();
    Task<Categoria> PesquisarCategoria(int id);
    Task<string> EditarCategoria(Categoria categoria);
    Task<string> ApagarCategoria(Categoria categoria);
}
