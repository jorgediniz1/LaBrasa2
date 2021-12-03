using LaBrasa.Shared.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LaBrasa.Shared.Contracts
{
    public interface IProdutoRepository
    {
        Task<Produto> AddAsync(Produto produto);
        Task<List<Produto>> GetAllAsync();
        Task<Produto> GetById(int id);
        Task<Produto> UpdateAsync(Produto produto);
        Task Delete(int id);
    }
}
