using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotelaria.DAO
{
    public class Conexao //criar 3 metodos
    {

        public SqlConnection getConexao() {
            string con = ConfigurationManager.ConnectionStrings["StringConexao"].ToString();
            return new SqlConnection(con);
        }

        /* 
        SqlConnection con = new SqlConnection(); //instanciando classe sqlconnection
        
        public Conexao() //1 - construtor
        {
            con.ConnectionString = @"Data Source=DESKTOP-JJG73MK\SQLEXPRESS;Initial Catalog=HotelMountain;User ID=teste;Password=adm123"; //endereco do banco de dados
                        
        }

        public SqlConnection conectar() //conectar no banco de dados
        {
            
            if (con.State == System.Data.ConnectionState.Closed) //verificando se a conexao ja não está aberta
            {
                con.Open(); //metodo para abrir a conexao
            }
            return con;
        }

        public void desconectar() //desconectar do banco de dados
        {
            if(con.State == System.Data.ConnectionState.Open) //verificando se a conexao está aberta
            {
                con.Close(); //metodo para fechar a conexao
            }
        }

        */

    }
}
