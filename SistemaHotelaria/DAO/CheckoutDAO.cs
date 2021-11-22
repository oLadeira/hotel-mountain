using SistemaHotelaria.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotelaria.DAO
{
    class CheckoutDAO
    {
        readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["StringConexao"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand();

        public void cadastrarCheckout(Check_out checkout)
        {
            try
            {
                con.Open();

                cmd.CommandText = "INSERT INTO checkOut (cpfHosped, idQuarto, entrada, saida, dias, total) VALUES (@cpfHosped, @idQuarto, @entrada, @saida, @dias, @total)";

                cmd2.CommandText = "UPDATE quarto SET status = 'DISPONIVEL' WHERE id = @id";

                cmd = new SqlCommand(cmd.CommandText, con);
                cmd2 = new SqlCommand(cmd2.CommandText, con);

                cmd.Parameters.AddWithValue("@cpfHosped", checkout.CpfHosped);
                cmd.Parameters.AddWithValue("@idQuarto", checkout.IdQuarto);
                cmd.Parameters.AddWithValue("@entrada", checkout.Entrada);
                cmd.Parameters.AddWithValue("@saida", checkout.Saida);
                cmd.Parameters.AddWithValue("@dias", checkout.Dias);
                cmd.Parameters.AddWithValue("@total", checkout.Total);

                cmd2.Parameters.AddWithValue("@id", checkout.IdQuarto);

                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();

                System.Windows.Forms.MessageBox.Show("Check-Out realizado com sucesso!", "Sucesso!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);

                System.Windows.Forms.Form.ActiveForm.Close();

            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable listarCheckOut()
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT c.id, c.cpfHosped, q.numero, c.entrada, c.saida, c.dias, c.total FROM checkOut as c INNER JOIN quarto as q ON c.idQuarto = q.id; ";


                SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con);
                DataTable tabela = new DataTable();

                da.Fill(tabela);

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

        public Check_in pesquisarCheckin(String cpf, Check_in check_in)
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM checkIn WHERE cpfHospede = @cpfHospede";

                cmd = new SqlCommand(cmd.CommandText, con);

                cmd.Parameters.AddWithValue("@cpfHospede", cpf);

                SqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    check_in.Id = reader.GetInt32(0);
                    check_in.CpfHospede = reader.GetString(1);
                    check_in.IdQuarto = reader.GetInt32(2);
                    check_in.Entrada = reader.GetDateTime(3);
                    check_in.Saida = reader.GetDateTime(4);
                    check_in.Dias = reader.GetInt32(5);                    
                } 
                
                if (reader.HasRows)
                {
                    return check_in;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Check-In previamente não realizado!");
                }
                return null;                
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


        public decimal calculaTotal(String cpf)
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT c.idQuarto, q.valor FROM checkIn as c INNER JOIN quarto as q ON idQuarto = q.id WHERE c.cpfHospede = @cpfHospede ";

                cmd = new SqlCommand(cmd.CommandText, con);

                cmd.Parameters.AddWithValue("@cpfHospede", cpf);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    return reader.GetDecimal(1);                 
                }
                return 0;
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return 0;
            }
            finally
            {
                con.Close();
            }
            
        }

        public DataTable listarCheckoutCpf(String cpf)
        {
            try
            {
                con.Open();

                cmd.CommandText = "SELECT * FROM checkOut WHERE cpfHosped =" + "'" + cpf + "'";

                SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con);

                DataTable tabela = new DataTable();

                da.Fill(tabela);

                return tabela;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return null;
        }


    }
}
