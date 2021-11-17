using SistemaHotelaria.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotelaria.DAO
{
    class QuartoDAO
    {
        readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["StringConexao"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        Quarto quarto = new Quarto();

        public void cadastrarQuarto(Quarto quarto)
        {
            try
            {
                con.Open();

                cmd.CommandText = "INSERT INTO quarto (categoria, valor, numero, status) VALUES (@categoria, @valor, @numero, @status)";

                cmd = new SqlCommand(cmd.CommandText, con);

                cmd.Parameters.AddWithValue("@categoria", quarto.Categoria);
                cmd.Parameters.AddWithValue("@valor", quarto.Valor);
                cmd.Parameters.AddWithValue("@numero", quarto.Numero);
                cmd.Parameters.AddWithValue("@status", quarto.Status);

                cmd.ExecuteNonQuery();

                System.Windows.Forms.MessageBox.Show("Quarto cadastrado com sucesso!", "Sucesso!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);

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

        public void alterarQuarto(int id, Quarto quarto)
        {
            try
            {
                con.Open();

                cmd.CommandText = "UPDATE quarto SET categoria = @categoria, valor = @valor, numero = @numero, status = @status WHERE id = @id";

                cmd = new SqlCommand(cmd.CommandText, con);

                cmd.Parameters.AddWithValue("@categoria", quarto.Categoria);
                cmd.Parameters.AddWithValue("@valor", quarto.Valor);
                cmd.Parameters.AddWithValue("@numero", quarto.Numero);
                cmd.Parameters.AddWithValue("@status", quarto.Status);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

                System.Windows.Forms.MessageBox.Show("Quarto Atualizado com sucesso!", "Sucesso!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);

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

        public DataTable listarQuarto()
        {
            try
            {
                con.Open();

                cmd.CommandText = "SELECT * FROM quarto";

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

        public DataTable listarQuartoComboBox() {

            try
            {
                con.Open();

                cmd.CommandText = "SELECT * FROM quarto WHERE status = 'DISPONIVEL';";
                                

                SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con);

                DataTable tabela = new DataTable();

                da.Fill(tabela);

                return tabela;
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally{
                con.Close();
            }
            return null;
        }

    }
}
