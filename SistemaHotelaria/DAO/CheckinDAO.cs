using SistemaHotelaria.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotelaria.DAO
{
    class CheckinDAO
    {
        readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["StringConexao"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        SqlCommand cmd2 = new SqlCommand();
        Check_in checkin = new Check_in();

        public void cadastrarCheckin(Check_in checkin)
        {
            try
            {
                con.Open();

                cmd.CommandText = "INSERT INTO checkin (cpfHospede, idQuarto, entrada, saida, dias) VALUES (@cpfHospede, @idQuarto, @entrada, @saida, @dias)";                           
                cmd = new SqlCommand(cmd.CommandText, con);

                cmd.Parameters.AddWithValue("@cpfHospede", checkin.CpfHospede);
                cmd.Parameters.AddWithValue("@idQuarto", checkin.IdQuarto);
                cmd.Parameters.AddWithValue("@entrada", checkin.Entrada);
                cmd.Parameters.AddWithValue("@saida", checkin.Saida);
                cmd.Parameters.AddWithValue("@dias", checkin.Dias);


                cmd2.CommandText = "UPDATE quarto SET status = 'OCUPADO' WHERE id = @id";

                cmd2 = new SqlCommand(cmd2.CommandText, con);

                cmd2.Parameters.AddWithValue("@id", checkin.IdQuarto);

                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();

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



    }
}
