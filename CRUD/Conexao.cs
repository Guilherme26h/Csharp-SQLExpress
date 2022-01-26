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

        String DB = //Url de Conexão com banco de dados

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
