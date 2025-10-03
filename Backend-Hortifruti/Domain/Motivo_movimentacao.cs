using System;
using System.Collections.Generic;

namespace Hortifruti.Domain;

public partial class Motivo_movimentacao
{
    public int Id { get; set; }

    public string TipoMovimentacao { get; set; } = null!;

    public bool Ativo { get; set; }

    public virtual ICollection<Entrada> Entrada { get; set; } = new List<Entrada>();

    public virtual ICollection<Saida> Saida { get; set; } = new List<Saida>();
}
