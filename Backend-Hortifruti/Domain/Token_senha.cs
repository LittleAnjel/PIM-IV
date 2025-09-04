namespace Hortifruti.Domain;

public class Token_senha
{
    public int id { get; set; }
    public int funcionario_id { get; set; }
    public string token {  get; set; }
    public DateTime data_geracao {  get; set; }

    public DateTime hora_geracao { get; set; }
}