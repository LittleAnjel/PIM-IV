namespace Hortifruti.Domain;

public class Estoque
{
    public int id {get; set;}
    public int produto_id {get; set;}
    public int quantidade_movimentacao {get; set;}
    public DateTime data_movimentacao {get; set;}
    public int funcionario_id {get; set;}
}