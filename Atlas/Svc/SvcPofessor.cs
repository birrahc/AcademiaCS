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
    internal static class SvcPofessor
    {
        internal static void CadastrarProfessor(Mdl.Professor pProfesssor)
        {
            //DbConnection conexao = DbConexao.ConexaoDB();
            //DbCommand comando = DbConexao.ComandosSql(conexao);
            //comando.CommandType = CommandType.Text;
            //comando.CommandText = "INSERT INTO professor (nome,nascimento,telefone, email, especialidade,formacao) VALUES (@nome,@nascimento,@telefone, @email, @especialidade,@formacao)";
            //comando.Parameters.Add(new MySqlParameter("@nome",pProfesssor.Nome));
            //comando.Parameters.Add(new MySqlParameter("@nascimento",pProfesssor.Nascimento));
            //comando.Parameters.Add(new MySqlParameter("@telefone",pProfesssor.Telefone));
            //comando.Parameters.Add(new MySqlParameter("@email",pProfesssor.Email));
            //comando.Parameters.Add(new MySqlParameter("@nome",pProfesssor.Formacao));
            //comando.ExecuteNonQuery();
        }
    }
}
