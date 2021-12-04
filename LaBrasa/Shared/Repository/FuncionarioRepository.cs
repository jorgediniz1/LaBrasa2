using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks; 
using LaBrasa.Shared.Entities;
using LaBrasa.Shared.Interfaces;
using System.Data.SqlClient;

namespace LaBrasa.Shared.Repository
{
    public class FuncionarioRepository : IFuncionarioRepo
    {
     
        public Task<Funcionario> IncluirFuncionario(Funcionario funcionario)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection())
                {
                    SqlCommand sqlCommand = new SqlCommand();

                    cn.ConnectionString = "DefaultConnection";

                    sqlCommand.Connection = cn;
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandText = ("INSERT INTO tb_funcionarios (NOME, DEPARTAMENTO, CPF, SEXO, TELEFONE, ENDERECO, EMAIL)" +
                                                                  " VALUES (@nome, @departamento, @cpf, @sexo, @telefone, @endereco, @email)");

                    sqlCommand.Parameters.AddWithValue("nome", funcionario.Nome);
                    sqlCommand.Parameters.AddWithValue("departamento", funcionario.Departamento);
                    sqlCommand.Parameters.AddWithValue("cpf", funcionario.Cpf);
                    sqlCommand.Parameters.AddWithValue("sexo", funcionario.Sexo);
                    sqlCommand.Parameters.AddWithValue("telefone", funcionario.Telefone);
                    sqlCommand.Parameters.AddWithValue("endereco", funcionario.Endereco);
                    sqlCommand.Parameters.AddWithValue("email", funcionario.Email);

                    cn.Open();
                    sqlCommand.ExecuteNonQuery();

                    cn.Close();









                }
            }
            catch
            {

            }
            
        }

        public Task<Funcionario> ApagarFuncionario(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Funcionario> AtualizarFuncionario(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }


        public Task<Funcionario> PegarPeloId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Funcionario> PegarTodos(Funcionario funcionario)
        {
            throw new NotImplementedException();
        }
    }
}
