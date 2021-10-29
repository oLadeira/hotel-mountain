using SistemaHotelaria.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaHotelaria.View.Checkin;


namespace SistemaHotelaria.DAO
{
    class CheckinDAO
    {
        readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["StringConexao"].ConnectionString);
        Check_in checkin = new Check_in();

        public void cadastrarCheckin(Check_in checkin)
        {
            try
            {
                con.Open();                               

                if (validarCpf(checkin.CpfHospede)) {
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "INSERT INTO checkin (cpfHospede, idQuarto, entrada, saida, dias) VALUES (@cpfHospede, @idQuarto, @entrada, @saida, @dias)";
                    cmd = new SqlCommand(cmd.CommandText, con);

                    cmd.Parameters.AddWithValue("@cpfHospede", checkin.CpfHospede);
                    cmd.Parameters.AddWithValue("@idQuarto", checkin.IdQuarto);
                    cmd.Parameters.AddWithValue("@entrada", checkin.Entrada);
                    cmd.Parameters.AddWithValue("@saida", checkin.Saida);
                    cmd.Parameters.AddWithValue("@dias", checkin.Dias);

                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.CommandText = "UPDATE quarto SET status = 'OCUPADO' WHERE id = @id";

                    cmd2 = new SqlCommand(cmd2.CommandText, con);

                    cmd2.Parameters.AddWithValue("@id", checkin.IdQuarto);

                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();

                    System.Windows.Forms.MessageBox.Show("Check-In cadastrado com sucesso!", "Sucesso!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);

                    System.Windows.Forms.Form.ActiveForm.Close();

                }
                else
                {
                    throw new Exception();
                }                          
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Hóspede não encontrado!");
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable listarCheckin()
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "SELECT c.id, c.cpfHospede, q.numero, c.entrada, c.saida, c.dias FROM checkIn as c INNER JOIN quarto AS q ON idQuarto = q.id;";

                SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con);
                DataTable tabela = new DataTable();

                da.Fill(tabela);
                return tabela;
            }
            catch
            {

            }
            finally
            {
                con.Close();
            }
            return null;
        }

        public bool validarCpf(String cpf)
        {
            try
            {                
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "SELECT * FROM hospede WHERE cpf ='" + cpf + "'";

                SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con);
                DataTable tabela = new DataTable();

                da.Fill(tabela);

                int totalRows = tabela.Rows.Count;

                if(totalRows > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
            }
            
        }

    }
}
