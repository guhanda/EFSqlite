using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfSqlite.Core.Entidades
{
    class PedidoItem
    {
        [Key]
        public long IdPedidoItem { get; set; }
        public Produto Produto { get; set; }
        public double Quantidade { get; set; }
    }
}
