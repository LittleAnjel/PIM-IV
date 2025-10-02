using System;
using System.Collections.Generic;

namespace Hortifruti.Domain;

/// <summary>
/// Tabela fixa (&quot;chumbada&quot;) com as operações do banco (CRUD)
/// </summary>
public partial class Operacao
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string Descricao { get; set; } = null!;

    public virtual ICollection<Permissao> Permissaos { get; set; } = new List<Permissao>();
}
