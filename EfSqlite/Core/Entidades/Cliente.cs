using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfSqlite.Core.Entidades
{
    class Cliente
    {
        [Key]
        public int IdCliente { get; set; }
        public int Cnpj { get; set; }
        public string Nome { get; set; }
    }
}
