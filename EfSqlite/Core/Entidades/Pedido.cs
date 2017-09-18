using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfSqlite.Core.Entidades
{
    class Pedido
    {
        [Key]
        public long IdPedido { get; set; }
        public string DsPedido { get; set; }
        public DateTime DataPedido { get; set; }

        public List<PedidoItem> PedidoItem { get; set; }
        public Cliente Cliente { get; set; }

    }
}
