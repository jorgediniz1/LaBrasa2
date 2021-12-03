using System.Collections.Generic;

namespace LaBrasa.Shared.Entities
{
    public class Mesa
    {
        public int NumeroMesa { get; set; }
        public int ComandasAbertas { get; set; }
        public int ComandasFechadas { get; set; }
        public List<Comanda> ComandasMesa { get; set; }

    }
}
