namespace Hortifruti.Domain;

public class Venda
{
    public int id {  get; set; }
    public string funcionario_id { get; set; }
    public string cadastro_clinte { get; set; }
    public decimal valor_total { get; set; }
    public bool desconto { get; set; }
    public decimal valor_desconto { get; set; }
    public DateTime datahora_vendas {  get; set; }

}