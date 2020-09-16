using System;
using System.Collections.Generic;

namespace API_DbFirst.Domains
{
    public partial class Pedido
    {
        public Pedido()
        {
            PedidoItem = new HashSet<PedidoItem>();
        }

        public Guid Id { get; set; }
        public string Status { get; set; }
        public DateTime OrderDate { get; set; }

        public virtual ICollection<PedidoItem> PedidoItem { get; set; }
    }
}
