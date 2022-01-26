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
        private string DB = @"Data Source=DEV-GUILHERME\SQLEXPRESS01;Initial Catalog = Biblioteca; Integrated Security = True";

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
