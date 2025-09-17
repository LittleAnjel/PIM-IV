namespace Hortifruti.Domain;

public class Funcionario
{
    public int id {get; set;}
    public string cpf {get; set;}
    //public int rg {get; set;} REALMENTE PRECISA?
    public string nome {get; set;}
    public string telefone {get; set;}
    public string telefone_extra {get; set;}
    public string email {get; set;}
    public string conta_bancaria {get; set;}
    public string agencia_bancaria {get; set;}
    public Boolean ativo {get; set;}
}