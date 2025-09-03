namespace Hortifruti.Domain;

public class Fornecedor_produto
{
    public int id {get; set;}
    public int produto_id {get; set;}
    public int fornecedor_id {get; set;}
    public int codigo_fornecedor {get; set;}
    public DateTime data_registro {get; set;}
    public Boolean disponibilidade {get; set;}
}