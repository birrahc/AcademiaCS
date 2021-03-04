using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data.Common;

namespace Atlas.ConexaoBD
{
    internal class ConexaoDataBase
    {
        protected static DbConnection ConexaoDB()
        {
            string server = ConfigurationManager.AppSettings["server"];
            string dataBase = ConfigurationManager.AppSettings["database"].ToString();
            string usuario = ConfigurationManager.AppSettings["user"].ToString();
            string password = ConfigurationManager.AppSettings["password"].ToString();
            DbConnection conexao = new MySqlConnection(@"Server=" + server + ";Database=" + dataBase + ";Uid=" + usuario + ";Pwd=" + password + ";");
            conexao.Open();
            return conexao;
        }

        protected static DbCommand ComandosSql(DbConnection conexao)
        {
            DbCommand comando = conexao.CreateCommand();
            return comando;

        }

        protected static DbDataReader LerDados(DbCommand comando)
        {
            return comando.ExecuteReader();
        }



    }
}
