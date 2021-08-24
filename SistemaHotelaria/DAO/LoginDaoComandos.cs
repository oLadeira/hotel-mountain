using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaHotelaria.DAO
{
    class LoginDaoComandos
    {
        public bool tem = false;
        public String mensagem = "";
        SqlCommand cmd = new SqlCommand(); //instaciando metodo responsavel pelas querys bd
        Conexao con = new Conexao(); //instanciando objeto Conexao da classe Conexao
        SqlDataReader dr;
        public String testando = "";

        public bool verificarLogin(String login, String senha)
        {
            //comandos sql para verificar se tem no banco
            //procurar no bd esse login e senha
            cmd.CommandText = "select * from loginFuncionarios where login = @login and senha = @senha"; //query bd
            cmd.Parameters.AddWithValue("@login", login); //escolhendo os parametros que serão substituidos na query
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                
                dr = cmd.ExecuteReader(); //executando a query          
                
                if (dr.HasRows) //se dr tem linhas
                {
                    tem = true; //variavel tem é true
                    
                }
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com o banco de dados!";
            }
            return tem;
        }





    }
}
