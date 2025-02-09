using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cadastro.API.Models;
[Table("produto")]
public class Produto
{
    [Column("id")]
    public int Id { get; set; }
    
    [Column("nome")]
    public string Nome { get; set; } = string.Empty;

    [Column("codigo")]
    public string Codigo { get; set; } = string.Empty;
    
    [Column("id_categoria")]
    public int Idcategoria { get; set; } 
}
