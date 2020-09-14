using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api_ORM.Domains
{
    public class Produto : BaseDomain
    {
        public string Nome { get; set; }
        public float Preco { get; set; }
        //relacionamento com a tabela pedidoitem 1 pra N
        public List<PedidoItem> PedidosItens { get; set; }

    }
}
