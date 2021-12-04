using LaBrasa.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaBrasa.Shared.Interfaces
{
    public interface IProdutoRepo
    {
        Task<Produto> IncluirProduto(Produto produto);
        Task<Produto> AtualizarProduto(Produto produto);
        Task<Produto> PegarTodos(Produto produto);
        Task<Produto> PegarPeloId(int id);
        Task<Produto> ApagarProduto(int id);
        
    }
}
