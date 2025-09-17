namespace Hortifruti.Domain;

public class Item_venda
{
    public int id {get; set;}
    public int venda_id {get; set;}
    public int produto_id {get; set;}
    public int quantidade {get; set;}
    public decimal valor {get; set;}
}