using System.Collections.Generic;

namespace LaBrasa.Shared.Entities
{
    public class Pedido
    {
        public double ValorPedido { get; set; }
        public Comanda ComandaPedido { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}
