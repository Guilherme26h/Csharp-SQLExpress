using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    /**
     * Classe de Conexão com Banco de Dados
     */
    public class Conexao
    {

        SqlConnection con = new SqlConnection();

        String DB = @"Data Source=DEV-GUILHERME\SQLEXPRESS01;Initial Catalog=test;Integrated Security=True"; //Caso Possua Password alterar os asteriscos para sua senha

        //Contrutor

        public Conexao()
        {
            con.ConnectionString = DB;

        }

        //Metodo Conexao BD
        public SqlConnection Conectar()
        {
            if(con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            
            return con;
        }
        //Desconectar BD
        public void Desconectar()
        {
            if(con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

    }
}
