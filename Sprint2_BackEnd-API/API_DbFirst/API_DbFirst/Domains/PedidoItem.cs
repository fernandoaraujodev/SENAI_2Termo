using System;
using System.Collections.Generic;

namespace API_DbFirst.Domains
{
    public partial class PedidoItem
    {
        public Guid Id { get; set; }
        public Guid IdPedido { get; set; }
        public Guid IdProduto { get; set; }
        public int Quantidade { get; set; }

        public virtual Pedido IdPedidoNavigation { get; set; }
        public virtual Produto IdProdutoNavigation { get; set; }
    }
}
