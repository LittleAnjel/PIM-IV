namespace Hortifruti.Domain;

public class Produto
{
    public int  id { get; set; }
    public int categoria { get; set; }
    public int unidade_medida { get; set; }
    public string nome { get; set; }
    public int codigo { get; set; }
    public string descricao { get; set; }

    public decimal preco { get; set; }

}