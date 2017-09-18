using EfSqlite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfSqlite
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ContextoEfSqlite())
            {
                db.Pedido.Add(new Core.Entidades.Pedido() {
                    DsPedido = "pedido 1",
                    DataPedido = DateTime.Now,
                    Cliente = new Core.Entidades.Cliente()
                    {
                        Cnpj = 012301230,
                        Nome = "Cliente Maluco"
                    },
                    PedidoItem = new List<Core.Entidades.PedidoItem>()
                    {
                        new Core.Entidades.PedidoItem()
                        {
                            Produto = new Core.Entidades.Produto()
                            {
                                Nome = "Espeto Carne"
                            },
                            Quantidade = 1
                        },
                        new Core.Entidades.PedidoItem()
                        {
                            Produto = new Core.Entidades.Produto()
                            {
                                Nome = "Espeto Frango"
                            },
                            Quantidade = 2
                        },
                    }
                });
                
                db.SaveChanges();


                foreach (var cat in db.Pedido.ToList())
                {
                    Console.WriteLine($"Pedido Id= {cat.IdPedido}, Desc Pedido = {cat.DsPedido}");
                }

                Console.ReadLine();
            }
        }
    }
}
