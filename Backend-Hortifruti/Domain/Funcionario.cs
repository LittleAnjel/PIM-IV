using System;
using System.Collections.Generic;

namespace Hortifruti.Domain;

public partial class Funcionario
{
    public int Id { get; set; }

    public int CargoId { get; set; }

    public string Cpf { get; set; } = null!;

    public string Rg { get; set; } = null!;

    public string Nome { get; set; } = null!;

    public string Telefone { get; set; } = null!;

    public string? TelefoneExtra { get; set; }

    public string Email { get; set; } = null!;

    public string ContaBancaria { get; set; } = null!;

    public string AgenciaBancaria { get; set; } = null!;

    public bool Ativo { get; set; }

    public virtual Cargo? Cargo { get; set; }

    public virtual ICollection<Historico_produto> HistoricoProdutos { get; set; } = new List<Historico_produto>();

    public virtual ICollection<Saida> Saida { get; set; } = new List<Saida>();

    public virtual ICollection<Token> Tokens { get; set; } = new List<Token>();

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
