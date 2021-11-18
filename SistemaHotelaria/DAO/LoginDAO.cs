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
    class LoginDAO
    {
        readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["StringConexao"].ConnectionString);

        public bool realizaLogin(String login, String senha) {

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "SELECT * FROM loginFuncionarios WHERE login =" + "'" + login + "'" +  "and senha =" + "'" +  senha + "'";
                               

                SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con);
                DataTable tabela = new DataTable();

                da.Fill(tabela);

                int totalRows = tabela.Rows.Count;

                if (totalRows > 0)
                {
                    return true;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                return false;
            }
            return false;
        }

    }

    
}

