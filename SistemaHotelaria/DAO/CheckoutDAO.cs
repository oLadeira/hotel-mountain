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
    class CheckoutDAO
    {
        readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["StringConexao"].ConnectionString);
        SqlCommand cmd = new SqlCommand();


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
                return 0;
            }
            
        }


    }
}
