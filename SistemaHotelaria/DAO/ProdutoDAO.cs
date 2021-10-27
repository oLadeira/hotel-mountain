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
    class ProdutoDAO
    {
        readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["StringConexao"].ConnectionString);
        SqlCommand cmd = new SqlCommand();


        public void cadastrarProduto(Produto produto)
        {
            try
            {
                con.Open();

                cmd.CommandText = "INSERT INTO produto (nome, categoria, quantidade, valorCompra, valorVenda, fornecedor) VALUES (@nome, @categoria, @quantidade, @valorCompra, @valorVenda, @fornecedor)";

                cmd = new SqlCommand(cmd.CommandText, con);

                cmd.Parameters.AddWithValue("@nome", produto.Nome);
                cmd.Parameters.AddWithValue("@categoria", produto.Categoria);
                cmd.Parameters.AddWithValue("@quantidade", produto.Quantidade);
                cmd.Parameters.AddWithValue("@valorCompra", produto.ValorCompra);
                cmd.Parameters.AddWithValue("@valorVenda", produto.ValorVenda);
                cmd.Parameters.AddWithValue("@fornecedor", produto.Fornecedor);

                cmd.ExecuteNonQuery();

                System.Windows.Forms.MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
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


        public DataTable listarFornecedoresComboBox()
        {
            try
            {
                con.Close();

                cmd.CommandText = "SELECT * FROM fornecedor";

                SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con);
                DataTable tabela = new DataTable();

                da.Fill(tabela);

                return tabela;                
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

    }
}
