using System;
using System.Collections.Generic;

namespace Hortifruti.Domain;

/// <summary>
/// Tabela fixa (&quot;chumbada&quot;) com os registros dos módulos do sistema.
/// 
/// ex: Produtos, Venda, Relatório, Funcionário etc.
/// </summary>
public partial class Modulo
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string? Descricao { get; set; }

    public bool Ativo { get; set; }

    public virtual ICollection<Permissao> Permissaos { get; set; } = new List<Permissao>();
}
