using LaBrasa.Shared.Entities;
using LaBrasa.Shared.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LaBrasa.Shared.Repository
{
    public class ProdutosRepository : IProdutoRepo
    {
      
        public Task<Produto> ApagarProduto(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Produto> AtualizarProduto(Produto produto)
        {
            throw new System.NotImplementedException();
        }

        public Task<Produto> IncluirProduto(Produto produto)
        {
            throw new System.NotImplementedException();
        }

        public Task<Produto> PegarPeloId(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Produto> PegarTodos(Produto produto)
        {
            throw new System.NotImplementedException();
        }
    }
}
