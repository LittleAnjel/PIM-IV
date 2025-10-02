using System;
using System.Collections.Generic;

namespace Hortifruti.Domain;

/// <summary>
/// Não sei como seria o relacionamento. Recebe id de produto (igual a item_saida?
/// </summary>
public partial class Item_entrada
{
    public int Id { get; set; }

    public int EntradaId { get; set; }

    public int ProdutoId { get; set; }

    public int Quantidade { get; set; }

    public string? Lote { get; set; }

    public string? Validade { get; set; }

    public virtual Entrada Entrada { get; set; } = null!;

    public virtual Produto Produto { get; set; } = null!;
}
