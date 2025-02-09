using System;

namespace Cadastro.API.DTO;

public class ProdutoDTO
{
     public int ProdutoId { get; set; } 

     public string Produto { get; set; } = string. Empty;

     public string Codigo { get; set;} = string.Empty;

     public int CategoriaId { get; set; } 

}
