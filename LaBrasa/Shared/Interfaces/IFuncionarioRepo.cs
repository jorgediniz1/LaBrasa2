using LaBrasa.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaBrasa.Shared.Interfaces
{
    public interface IFuncionarioRepo
    {
        Task<Funcionario> IncluirFuncionario(Funcionario funcionario);
        Task<Funcionario> AtualizarFuncionario(Funcionario funcionario);
        Task<Funcionario> PegarTodos(Funcionario funcionario);
        Task<Funcionario> PegarPeloId(int id);
        Task<Funcionario> ApagarFuncionario(int id);
       
    }
}
