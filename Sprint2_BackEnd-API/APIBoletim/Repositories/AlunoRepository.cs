using APIBoletim.Context;
using APIBoletim.Domains;
using APIBoletim.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace APIBoletim.Repositories
{
    public class AlunoRepository : IAluno
    {

        // Chamamos a classe de conexão do banco
        BoletimContext conexao = new BoletimContext();

        //Chamamos o objeto responsavel para receber e executar os comandos do banco
        SqlCommand cmd = new SqlCommand();


        public Aluno Alterar(int id, Aluno a)
        {
            cmd.Connection = conexao.Conectar();

            cmd.CommandText = "UPDATE Aluno SET " +
                "Nome = @nome, " +
                "Ra = @ra, " +
                "Idade = @idade WHERE IdAluno = @id ";

            cmd.Parameters.AddWithValue("@nome", a.Nome);
            cmd.Parameters.AddWithValue("@ra", a.RA);
            cmd.Parameters.AddWithValue("@idade", a.Idade);

            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();

            conexao.Desconectar();
            return a;
        }

        public Aluno BuscarPorId(int id)
        {
            cmd.Connection = conexao.Conectar();

            cmd.CommandText = "SELECT * FROM Aluno WHERE IdAluno = @id ";
            
            //Atribuimos as variaveis que vem como argumento
            cmd.Parameters.AddWithValue("@id", id);

            //Dando o play
            SqlDataReader dados = cmd.ExecuteReader();

            Aluno a = new Aluno();

            while (dados.Read())
            {
                a.IdAluno   = Convert.ToInt32(dados.GetValue(0));
                a.Nome      = Convert.ToString(dados.GetValue(1));
                a.RA        = Convert.ToString(dados.GetValue(2));
                a.Idade     = Convert.ToInt32(dados.GetValue(3));

            }

            conexao.Desconectar();

            return a;
        }

        public Aluno Cadastrar(Aluno a)
        {
            cmd.Connection = conexao.Conectar();

            cmd.CommandText =
                "INSERT INTO Aluno (Nome, RA, Idade) " +
                "VALUES" +
                "(@nome, @ra, @idade)";
            cmd.Parameters.AddWithValue("@nome", a.Nome);
            cmd.Parameters.AddWithValue("@ra", a.RA);
            cmd.Parameters.AddWithValue("@idade", a.Idade);

            // Será este comando o responsável por injetar os dados no banco efetivamente
            cmd.ExecuteNonQuery();

            conexao.Desconectar();

            return a;
        }

        public void Excluir(int id)
        {
            cmd.Connection = conexao.Conectar();

            cmd.CommandText = "DELETE FROM Aluno WHERE IdAluno = @id";
            cmd.Parameters.AddWithValue("@id", id);
            
            cmd.ExecuteNonQuery();

            conexao.Desconectar();
        }

        public List<Aluno> LerTodos()
        {
            // Abrir conexão
            cmd.Connection = conexao.Conectar();

            // Preparar a query (CONSULTA)
            cmd.CommandText = "SELECT * FROM Aluno";

            // Dando o play
            SqlDataReader dados = cmd.ExecuteReader();

            // Criamos alista para guardar os alunos
            List<Aluno> alunos = new List<Aluno>();

            while(dados.Read())
            {
                alunos.Add(
                    new Aluno()
                    {

                        IdAluno     = Convert.ToInt32(dados.GetValue(0)),
                        Nome        = Convert.ToString(dados.GetValue(1)),
                        RA          = Convert.ToString(dados.GetValue(2)),
                        Idade       = Convert.ToInt32(dados.GetValue(3)),

                    }
                );
            }


            // Fechar conexão
            conexao.Desconectar();

            return alunos;
        }
    }
}
