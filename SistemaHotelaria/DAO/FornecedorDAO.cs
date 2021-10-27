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
    class FornecedorDAO
    {

        readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["StringConexao"].ConnectionString);
        SqlCommand cmd = new SqlCommand();


        public void cadastrarFornecedor(Fornecedor fornecedor)
        {
            try
            {
                con.Open();

                cmd.CommandText = "INSERT INTO fornecedor(nomeFantasia, razaoSocial, endereco, cnpj, email, telefone, categoria) VALUES (@nomeFantasia, @razaoSocial, @endereco, @cnpj, @email, @telefone, @categoria)";

                cmd = new SqlCommand(cmd.CommandText, con);

                cmd.Parameters.AddWithValue("@nomeFantasia", fornecedor.NomeFantasia);
                cmd.Parameters.AddWithValue("@razaoSocial", fornecedor.RazaoSocial);
                cmd.Parameters.AddWithValue("@endereco", fornecedor.Endereco);
                cmd.Parameters.AddWithValue("@cnpj", fornecedor.Cnpj);
                cmd.Parameters.AddWithValue("@email", fornecedor.Email);
                cmd.Parameters.AddWithValue("@telefone", fornecedor.Telefone);
                cmd.Parameters.AddWithValue("@categoria", fornecedor.Categoria);

                cmd.ExecuteNonQuery();

                System.Windows.Forms.MessageBox.Show("Fornecedor cadastrado com sucesso!", "Sucesso!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);

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
