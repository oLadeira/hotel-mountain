using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaHotelaria.Modelo;
using System.Configuration;
using System.Data;
using SistemaHotelaria.View;

namespace SistemaHotelaria.DAO
{
    class HospedeDAO
    {

        //instanciando a classe de conexao, a string que possui o endereco do banco está no arquivo App.config
        readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["StringConexao"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        Hospede hospede = new Hospede();

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

                System.Windows.Forms.MessageBox.Show("Hóspede cadastrado com sucesso!", "Sucesso!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                                
            }
            catch(SqlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);

            }
            finally
            {
                con.Close();
            }                   
        }

        public Hospede dadosAlterar(int id, Hospede hospede) {

            try
            {                
                
                con.Open();
                cmd.CommandText = "SELECT * FROM hospede WHERE id = @id";

                cmd = new SqlCommand(cmd.CommandText, con);

                cmd.Parameters.AddWithValue("@id", id);


                SqlDataReader reader = cmd.ExecuteReader();

                
                while (reader.Read())
                {
                    //lblTeste.Text = reader.GetString(1).ToString();

                    hospede.Id = reader.GetInt32(0);
                    hospede.Nome = reader.GetString(1);
                    hospede.Telefone = reader.GetString(2);
                    hospede.Email = reader.GetString(3);
                    hospede.Cpf = reader.GetString(4);
                    hospede.Cep = reader.GetString(5);
                    hospede.Endereco = reader.GetString(6);
                    hospede.NumeroEndereco = reader.GetString(7);
                    hospede.Estado = reader.GetInt32(8);
                    hospede.Cidade = reader.GetString(9);                                  
                }                                                         
                return hospede;               
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                con.Close();
            }
            
        }      
       
       public void alterarHospede(int id, Hospede hospede)
        {
            try
            {
                con.Open();

                cmd.CommandText = "UPDATE hospede SET nome = @nome, telefone = @telefone, email = @email, cpf = @cpf, cep = @cep, endereco = @endereco, numeroEndereco = @numeroEndereco, estado = @estado, cidade = @cidade WHERE id = @id";

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
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

                System.Windows.Forms.MessageBox.Show("Hóspede Atualizado com sucesso!", "Sucesso!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                               
            }
            catch(SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void deletarHospedeById(int id)
        {
            try
            {
                con.Open();

                cmd = new SqlCommand(cmd.CommandText, con);

                cmd.CommandText = "DELETE FROM hospede WHERE id = @id";

                cmd.Parameters.AddWithValue("id", id);

                cmd.ExecuteNonQuery();

                System.Windows.Forms.MessageBox.Show("Hóspede Excluído com sucesso!", "Sucesso!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
            catch(SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        public DataTable listarHospedes()
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT h.id, h.nome, h.telefone, h.email, h.cpf, h.cep, h.endereco, h.numeroEndereco, e.nome as estado, h.cidade FROM hospede as h INNER JOIN estado as e ON h.estado = e.id";


                SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con);
                DataTable tabela = new DataTable();

                da.Fill(tabela);

                //dgvHospedes.DataSource = tabela;

                return tabela;
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return null;
        }

        public DataTable listarEstadoComboBox()
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM estado";

                SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con);
                DataTable tabela = new DataTable();

                da.Fill(tabela);

                //dgvHospedes.DataSource = tabela;

                
                return tabela;
            }
            
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return null;
        }
    }
}
