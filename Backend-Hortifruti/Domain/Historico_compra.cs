namespace Hortifruti.Domain;

public class Historico_compra
{
    public int id {get; set;}
    public int fornecedor_produto {get; set;}
    public decimal preco_total {get; set;}
    public DateTime data_compra {get; set;}
    public string lote {get; set;}
    public  DateTime validade {get; set;}
}