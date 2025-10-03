using System;
using System.Collections.Generic;

namespace Hortifruti.Domain;

/// <summary>
/// 1) Necessário adaptar estrutura por conta do keycloak?
/// 
/// 2) Necessário essa tabela? Juntar com funcionario?
/// 
/// 3) Necessário verificar o tamanho da hash gerada e qual vai ser o &quot;salt&quot;
/// </summary>
public partial class Usuario
{
    public int Id { get; set; }

    public int FuncionarioId { get; set; }

    public string Login { get; set; } = null!;

    public string Senha { get; set; } = null!;

    public bool Ativo { get; set; }

    public virtual Funcionario Funcionario { get; set; } = null!;

    public virtual ICollection<Log_login> LogLogins { get; set; } = new List<Log_login>();
}
