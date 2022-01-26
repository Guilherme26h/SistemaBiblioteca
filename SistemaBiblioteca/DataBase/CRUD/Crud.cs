using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBiblioteca
{
    internal class Crud
    {
        SqlCommand cmd = new SqlCommand();
        Connection connection = new Connection();
        public string msg = "";
        DataGridView dados;
        
        


        public String Insert(string nome, string autor, string genero, string resumo)
        {
            cmd.CommandText = "INSERT INTO tbl_BooksCatalog (name, author, gender, abstract) VALUES (@name, @author, @gender, @abstract)";
            cmd.Parameters.AddWithValue("@name", nome);
            cmd.Parameters.AddWithValue("@author", autor);
            cmd.Parameters.AddWithValue("@gender", genero);
            cmd.Parameters.AddWithValue("@abstract", resumo);
            try
            {
                cmd.Connection = connection.conectar();
                cmd.ExecuteNonQuery();
                connection.Desconectar();
                this.msg = "cadastrado com sucesso";


            }
            catch (SqlException ex)
            {
                this.msg = "Erro ao cadastrar" + ex;
            }

            return this.msg;
        }

        public String Remove(int id)
        {
            cmd.CommandText = "DELETE tbl_BooksCatalog WHERE id = @id";
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                cmd.Connection = connection.conectar();
                cmd.ExecuteNonQuery();
                connection.Desconectar();
                this.msg = "Remoção efetuada com sucesso";
            }
            catch (SqlException ex)
            {
                this.msg = "Falha ao efetuar remoção" + ex;
            }

            return this.msg;
        }

        
        
        
    }
}
