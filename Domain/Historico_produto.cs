namespace Hortifruti.Domain;

public class Historico_produto
{
    public int id {get; set;}
    public int produto_id {get; set;}
    public decimal preco_produto {get; set;}
    public DateTime data_compra {get; set;}
    public int funcionario_id {get; set;}
}