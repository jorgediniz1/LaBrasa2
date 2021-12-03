namespace LaBrasa.Shared.Entities
{
    public class Produto
    {
        public string NomeProduto { get; set; }
        public string TipoProduto { get; set; }
        public int QuantidadeEstoque { get; set; }
        public int QuantidadeMinima { get; set; }
        public int QuantidadeAdicionar { get; set; }
        public double PrecoCusto { get; set; }
        public double PrecoVenda { get; set; }
    }
}
