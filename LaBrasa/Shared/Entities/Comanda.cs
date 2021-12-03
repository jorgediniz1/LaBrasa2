using System;
using System.Collections.Generic;

namespace LaBrasa.Shared.Entities
{
    public class Comanda
    {
        public double ValorTotal { get; set; }
        public DateTime DataHoraAbertura { get; set; }
        public double DataHoraFechamento { get; set; }
        public bool StatusComanda { get; set; }
        public List<Pedido> PedidosComanda { get; set; }
        public Mesa Mesa { get; set; }

    }
}
