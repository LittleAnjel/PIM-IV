using System;
using System.Collections.Generic;

namespace Hortifruti.Domain;

/// <summary>
/// Depende da resposta de produto_fornecedor
/// 
/// id 1
/// nota x
/// preco y
/// data w/z/k
/// fornecedor a
/// 
/// id 1
/// entrada 1
/// produto_id 1
/// quant 100
/// lote b
/// validade null
/// 
/// id 1
/// entrada 1
/// produto_id 1
/// quant 100
/// lote b
/// validade null
/// </summary>
public partial class Entrada
{
    public int Id { get; set; }

    public int FornecedorId { get; set; }

    public int MotivoMovimentacaoId { get; set; }

    public decimal PrecoTotal { get; set; }

    public DateOnly DataCompra { get; set; }

    public string NumeroNota { get; set; } = null!;

    public string NotaFiscal { get; set; } = null!;

    public virtual Fornecedor Fornecedor { get; set; } = null!;

    public virtual ICollection<Item_entrada> ItemEntrada { get; set; } = new List<Item_entrada>();

    public virtual Motivo_movimentacao MotivoMovimentacao { get; set; } = null!;
}
