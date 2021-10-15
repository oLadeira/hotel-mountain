using SistemaHotelaria.Model;
using SistemaHotelaria.Modelo;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SistemaHotelaria.DAO
{
    class FuncionarioDAO
    {
        readonly SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["StringConexao"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        Funcionario funcionario = new Funcionario();
        Hospede hospede = new Hospede();
        public void inserirFuncionario() {

            try
            {
                con.Open();
                cmd.CommandText = "INSERT INTO funcionario VALUES (@nome, @email, @cpf, @cep, @estadoCivil, @telefone, @sexo, @endereco, @numero, @cargo, @turno)";

                cmd = new SqlCommand(cmd.CommandText, con);

                cmd.Parameters.AddWithValue("nome", hospede.Nome);

            }
            catch(SqlException ex)
            {

            }
            finally
            {
                con.Close();
            }

        }


        public DataTable listarFuncionarios()
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT f.id, f.nome, f.email, f.cpf, f.cep,f.estadoCivil, f.telefone, f.sexo, f.endereco,f.numero, c.cargo, f.turno FROM funcionario as f INNER JOIN cargo as c ON f.cargo = c.id;";

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
