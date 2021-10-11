using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaHotelaria.Modelo;
using System.Configuration;

namespace SistemaHotelaria.DAO
{
    class HospedeDAO
    {

        //instanciando a classe de conexao, a string que possui o endereco do banco está no arquivo App.config
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["StringConexao"].ConnectionString);
        SqlCommand cmd = new SqlCommand();

        public void cadastrarHospede(Hospede hospede) {
                        

            try {
                con.Open();
                //executando o comando
                cmd.CommandText = "INSERT INTO hospede(nome, telefone, email, cpf, cep, endereco, numeroEndereco, estado, cidade) VALUES (@nome, @telefone, @email, @cpf, @cep, @endereco, @numeroEndereco, @estado, @cidade)"; //usar stored procedures and transactions

                cmd = new SqlCommand(cmd.CommandText, con);

                cmd.Parameters.AddWithValue("@nome", hospede.Nome);
                cmd.Parameters.AddWithValue("@telefone", hospede.Telefone);
                cmd.Parameters.AddWithValue("@email", hospede.Email);
                cmd.Parameters.AddWithValue("@cpf", hospede.Cpf);
                cmd.Parameters.AddWithValue("@cep", hospede.Cep);
                cmd.Parameters.AddWithValue("@endereco", hospede.Endereco);
                cmd.Parameters.AddWithValue("@numeroEndereco", hospede.NumeroEndereco);
                cmd.Parameters.AddWithValue("@estado", hospede.Estado);
                cmd.Parameters.AddWithValue("@cidade", hospede.Cidade);


                cmd.ExecuteNonQuery();
                con.Close();

                System.Windows.Forms.MessageBox.Show("Hóspede cadastrado com sucesso!", "Sucesso!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);

                

            }
            catch(SqlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
                
            }
            
        
        }

        
        
        /*
        public void cadastrar(String nome)
        {            
            Hospede hospede = new Hospede();
            hospede.setNome(nome);
            

            cmd.CommandText = "insert into hospedes values (@nome, @dataNasci, @estadoCivil, @telefone)";
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@dataNasci", nome);
            cmd.Parameters.AddWithValue("@estadoCivil", nome);
            cmd.Parameters.AddWithValue("@telefone", nome);

            try
            {
                cmd.Connection = con.conectar();

                cmd.ExecuteNonQuery(); //executando a query    
                                                                              
            }
            catch (SqlException)
            {
                this.mensagem = "Erro ao inserir novo hóspede! Contato o administrador do banco de dados";
            }

        }

        */
    }
}
