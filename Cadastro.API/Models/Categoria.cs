using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cadastro.API.Models;

[Table("categoria")]
public class Categoria
{
    [Column("id")]
    public int Id { get; set; }
    
    [Column("nome")]
    public string Nome { get; set; } = string.Empty;
}
