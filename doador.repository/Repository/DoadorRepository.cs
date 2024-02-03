using Dapper;
using doador.domain.Comamands;
using doador.domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static doador.repository.Repository.DoadorRepository;

namespace doador.repository.Repository
{
    public class DoadorRepository : IDoadorRepository
    {
        string conexao = @"Server=(localdb)\mssqllocaldb;Database=Cadastrodoador;Trusted_Connection=True;MultipleActiveResultSets=true";

        public Task GetAsync(DoadorCommand command)
        {
            throw new NotImplementedException();
        }

        public Task<string> PostAsync(DoadorCommand command)
        {
            string queryInsertDoador = @"
            INSERT INTO DOADOR(DoadorId, DoadorNome, Cidade, Estado,Cep,Email,Telefone)
            VALUES(@DoadorId, @DoadorNome, @Cidade, @Estado, @Cep,@Email,@Telefone)
            ";

            using (SqlConnection con = new SqlConnection(conexao))
            {
                con.Execute(queryInsertDoador, new
                {
                    DoadorId = command.DoadorId,
                    DoadorNome = command.DoadorNome,
                    Cidade= command.Cidade,
                    Estado = command.Estado,
                    Cep = command.Cep,
                    Email = command.Email,
                    Telefone = command.Telefone
                });

                return Task.FromResult("Cadastro realizado com sucesso");
            }


        } 








    }
}