using System;
using System.Collections.Generic;

namespace Hortifruti.Domain;

public partial class Unidade_medida
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public string Abreviacao { get; set; } = null!;

    public virtual ICollection<Produto> Produtos { get; set; } = new List<Produto>();
}
