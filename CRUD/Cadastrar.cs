using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    internal class Cadastrar
    {

        SqlCommand cmd = new SqlCommand();
        Conexao conexao = new Conexao();
        public String messagem = "";


        public Cadastrar(String nome, String telefone)
        {
            //Comando Sql - Insert
            cmd.CommandText = "INSERT INTO Cadastrar(Nome, Telefone) values (@nome, @telefone)";

            //parametros
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@telefone", telefone);

            try
            {
                cmd.Connection = conexao.Conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                this.messagem = "Cadastrado com sucesso";
            }
            catch(SqlException ex)
            {
                this.messagem = "Erro ao Conectar-se" + ex;
            }
           
        }
    }
}
