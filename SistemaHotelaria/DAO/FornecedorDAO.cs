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

        public DataTable listarFornecedores()
        {
            try
            {
                con.Open();
                cmd.CommandText = "select id, nomeFantasia, razaoSocial, endereco, cnpj, email, telefone, categoria FROM fornecedor;";

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

        public Fornecedor dadosAlterar(int id, Fornecedor fornecedor)
        {
            try
            {
                if (validarFornecedor(id) == true)
                {
                    con.Open();
                    cmd.CommandText = "SELECT * FROM fornecedor WHERE id = @id";

                    cmd = new SqlCommand(cmd.CommandText, con);

                    cmd.Parameters.AddWithValue("@id", id);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        fornecedor.Id = reader.GetInt32(0);
                        fornecedor.NomeFantasia = reader.GetString(1);
                        fornecedor.RazaoSocial = reader.GetString(2);
                        fornecedor.Endereco = reader.GetString(3);
                        fornecedor.Cnpj = reader.GetString(4);
                        fornecedor.Email = reader.GetString(5);
                        fornecedor.Telefone = reader.GetString(6);
                        fornecedor.Categoria = reader.GetString(7);
                    }
                    return fornecedor;
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
                MessageBox.Show("Fornecedor não encontrado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return fornecedor;
        }

        public void alterarFornecedor(int id, Fornecedor fornecedor)
        {
            try
            {
                con.Open();

                cmd.CommandText = "UPDATE fornecedor SET nomeFantasia = @nomeFantasia, razaoSocial = @razaoSocial, endereco = @endereco, cnpj = @cnpj, email = @email, telefone = @telefone, categoria = @categoria WHERE id = @id";

                cmd = new SqlCommand(cmd.CommandText, con);

                cmd.Parameters.AddWithValue("@nomeFantasia", fornecedor.NomeFantasia);
                cmd.Parameters.AddWithValue("@razaoSocial", fornecedor.RazaoSocial);
                cmd.Parameters.AddWithValue("@endereco", fornecedor.Endereco);
                cmd.Parameters.AddWithValue("@cnpj", fornecedor.Cnpj);
                cmd.Parameters.AddWithValue("@email", fornecedor.Email);
                cmd.Parameters.AddWithValue("@telefone", fornecedor.Telefone);
                cmd.Parameters.AddWithValue("@categoria", fornecedor.Categoria);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor Atualizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        public bool validarFornecedor(int id)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "SELECT * FROM fornecedor WHERE id =" + id;

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
                MessageBox.Show("Fornecedor não encontrado!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                con.Close();
            }
            return false;
        }

        public void deletarFornecedorById(int id)
        {
            try
            {
                con.Open();

                cmd = new SqlCommand(cmd.CommandText, con);

                cmd.CommandText = "DELETE FROM fornecedor WHERE id = @id";

                cmd.Parameters.AddWithValue("id", id);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Fornecedor Excluído com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Form.ActiveForm.Close();
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

        public DataTable listarFornecedorNome(String nome)
        {
            try
            {
                con.Open();

                cmd.CommandText = "SELECT * FROM fornecedor WHERE nomeFantasia LIKE " + "'%" + nome + "%'";

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
