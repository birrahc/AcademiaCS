
using Atlas.ConexaoBD;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atlas.Svc
{
    internal static class SvcAluno
    {
        internal static void InserirDadosAluno(Mdl.Aluno aluno)
        {
            
            VerificaDados(aluno);

            DbConnection conexao = DbConexao.ConexaoDB();
            DbCommand comando = DbConexao.ComandosSql(conexao);
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO aluno (nome, telefone, email) VALUES (@nome, @telefone, @email)";
            comando.Parameters.Add(new MySqlParameter("@nome", aluno.Nome));
            //comando.Parameters.Add(new MySqlParameter("@nascimento", aluno.Nascimento));
            //comando.Parameters.Add(new MySqlParameter("@cpf", aluno.Cpf));
            comando.Parameters.Add(new MySqlParameter("@telefone", aluno.Telefone));
            comando.Parameters.Add(new MySqlParameter("@email", aluno.Email));
            comando.ExecuteNonQuery();

        }

        internal static void VerificaDados(Mdl.Aluno aluno)
        {  
            if (aluno == null)
            {
                throw new ArgumentException(nameof(aluno));
            }
            if (String.IsNullOrEmpty(aluno.Nome))
            {
                throw new ArgumentException("O Campo Nome não pode de estar vazio");

                if (aluno.Nascimento == null || aluno.Nascimento.ToString() == "")
                {
                    throw new ArgumentException("O Campo Nascimento pode ficar vazio");
                }
            }
        }
    }
}
