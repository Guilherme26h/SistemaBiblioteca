using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Classe de Conexão com banco de dados
 */
namespace SistemaBiblioteca
{
    public class Connection
    {
        SqlConnection con = new SqlConnection();
        private string DB = //Url de conexão com banco de dados SQL Express";

        public Connection()
        {
            con.ConnectionString = DB;
        }        

        public SqlConnection conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        public void Desconectar()
        {
            if(con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
