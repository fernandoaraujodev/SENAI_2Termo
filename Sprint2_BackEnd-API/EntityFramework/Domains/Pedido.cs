using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EntityFramework.Domains
{
    public class Pedido
    {
        /// <summary>
        /// Define a classe Produto
        /// </summary>
        [Key]
        public Guid Id { get; set; }
        public string Status { get; set; }
        public DateTime OrderDate { get; set; }

        public Pedido()
        {
            Id = Guid.NewGuid();
        }
    }
}
