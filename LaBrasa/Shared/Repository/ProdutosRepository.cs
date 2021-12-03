using LaBrasa.Shared.Contracts;
using LaBrasa.Shared.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;
using con = LaBrasa.Shared.Context;

namespace LaBrasa.Shared.Repository
{
    public class ProdutosRepository : IProdutoRepository
    {
        private readonly con.Context _context;
        public ProdutosRepository(con.Context context)
        {
            _context = context;
        }
        public Task<Produto> AddAsync(Produto produto)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<Produto>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<Produto> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Produto> UpdateAsync(Produto produto)
        {
            throw new System.NotImplementedException();
        }
    }
}
