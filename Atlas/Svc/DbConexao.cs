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
    internal class DbConexao
    {

        internal static DbConnection ConexaoDB()
        {
            string server = ConfigurationManager.AppSettings["server"];
            string dataBase = ConfigurationManager.AppSettings["database"].ToString();
            string usuario = ConfigurationManager.AppSettings["user"].ToString();
            string password = ConfigurationManager.AppSettings["password"].ToString();
            string connectionString = null;
            DbConnection conexao = null;

            if (ConfigurationManager.AppSettings["provider"].ToString().Equals("MYSQL"))
            {
                connectionString = @"Server=" + server + ";Database=" + dataBase + ";Uid=" + usuario + ";Pwd=" + password + ";";

                conexao = new MySqlConnection(connectionString);
            }
            else
            {
                connectionString = @"Server=" + server + ";Database=" + dataBase + ";User Id=" + usuario + ";Password=" + password + ";";

                conexao = new SqlConnection(connectionString);
            }

            conexao.Open();//Abrindo a conexao

            return conexao;//retornando a conexao aberta

        }

        
        internal static DbCommand ComandosSql(DbConnection conexao) 
        {
            DbCommand comando = conexao.CreateCommand();
            return comando;
            
        }

        internal static DbDataReader LerDados(DbCommand comando) 
        {
            return comando.ExecuteReader();
        }

       
        
    }
}
