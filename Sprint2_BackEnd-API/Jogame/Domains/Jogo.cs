using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Jogame.Domains
{
    public class Jogo : BaseDomain
    {
    
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public DateTime DataLancamento { get; set; }

    }
}
