using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaHotelaria.Modelo;

namespace SistemaHotelaria.DAO
{
    class CadastroUsuarioDaoComandos
    {
        SqlCommand cmd = new SqlCommand();
        Conexao con = new Conexao();
        
        
        
        public void cadastrar(String nome)
        {            
            Hospede hospede = new Hospede();
            hospede.setNome(nome);

            cmd.CommandText = "insert into hospedes values (@nome)";
            cmd.Parameters.AddWithValue("@nome", nome);

            try
            {
                cmd.Connection = con.conectar();

                cmd.ExecuteNonQuery(); //executando a query          
                                               
            }
            catch (SqlException)
            {
                //this.mensagem = "Erro com o banco de dados!";
            }

        }
    }
}
