using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfSqlite.Core.Entidades
{
    class Produto
    {
        [Key]
        public long IdProduto { get; set; }
        public string Nome { get; set; }
    }
}
