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
        
        public void inserirFuncionario(Funcionario funcionario) {

            try
            {
                con.Open();
                cmd.CommandText = "INSERT INTO funcionario (nome, email, cpf, cep, estadoCivil, telefone, sexo, endereco, numero, cargo, turno) VALUES (@nome, @email, @cpf, @cep, @estadoCivil, @telefone, @sexo, @endereco, @numero, @cargo, @turno)";

                cmd = new SqlCommand(cmd.CommandText, con);

                cmd.Parameters.AddWithValue("@nome", funcionario.Nome);
                cmd.Parameters.AddWithValue("@email", funcionario.Email);
                cmd.Parameters.AddWithValue("@cpf", funcionario.Cpf);
                cmd.Parameters.AddWithValue("@cep", funcionario.Cep);
                cmd.Parameters.AddWithValue("@estadoCivil", funcionario.EstadoCivil);
                cmd.Parameters.AddWithValue("@telefone", funcionario.Telefone);
                cmd.Parameters.AddWithValue("@sexo", funcionario.Sexo);
                cmd.Parameters.AddWithValue("@endereco", funcionario.Endereco);
                cmd.Parameters.AddWithValue("@numero", funcionario.Numero);
                cmd.Parameters.AddWithValue("@cargo", funcionario.Cargo);
                cmd.Parameters.AddWithValue("@turno", funcionario.Turno);

                cmd.ExecuteNonQuery();

                System.Windows.Forms.MessageBox.Show("Funcionário cadastrado com sucesso!", "Sucesso!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
            catch(SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public Funcionario dadosAlterar(int id, Funcionario funcionario)
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM funcionario WHERE id = @id";

                cmd = new SqlCommand(cmd.CommandText, con);

                cmd.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    
                    funcionario.Id = reader.GetInt32(0);
                    funcionario.Nome = reader.GetString(1);
                    funcionario.Email = reader.GetString(2);
                    funcionario.Cpf = reader.GetString(3);
                    funcionario.Cep = reader.GetString(4);
                    funcionario.EstadoCivil = reader.GetString(5);
                    funcionario.Telefone = reader.GetString(6);
                    funcionario.Sexo = reader.GetString(7);                                   
                    funcionario.Endereco = reader.GetString(8);
                    funcionario.Numero = reader.GetString(9);
                    funcionario.Cargo = reader.GetInt32(10);
                    funcionario.Turno = reader.GetString(11);                                  
                }
                return funcionario;
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

        public void alterarHospede(int id, Funcionario funcionario)
        {
            try
            {
                con.Open();

                cmd.CommandText = "UPDATE funcionario SET nome = @nome, email = @email, cpf = @cpf, cep = @cep, estadoCivil = @estadoCivil, telefone = @telefone, sexo = @sexo, endereco = @endereco, numero = @numero, cargo = @cargo, turno = @turno WHERE id = @id";

                cmd = new SqlCommand(cmd.CommandText, con);

                cmd.Parameters.AddWithValue("@nome", funcionario.Nome);
                cmd.Parameters.AddWithValue("@email", funcionario.Email);
                cmd.Parameters.AddWithValue("@cpf", funcionario.Cpf);
                cmd.Parameters.AddWithValue("@cep", funcionario.Cep);
                cmd.Parameters.AddWithValue("@estadoCivil", funcionario.EstadoCivil);
                cmd.Parameters.AddWithValue("@telefone", funcionario.Telefone);
                cmd.Parameters.AddWithValue("@sexo", funcionario.Sexo);
                cmd.Parameters.AddWithValue("@endereco", funcionario.Endereco);
                cmd.Parameters.AddWithValue("@numero", funcionario.Numero);
                cmd.Parameters.AddWithValue("@cargo", funcionario.Cargo);
                cmd.Parameters.AddWithValue("@turno", funcionario.Turno);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

                System.Windows.Forms.MessageBox.Show("Funcionário Atualizado com sucesso!", "Sucesso!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);

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

        public void deletarFuncionarioById(int id)
        {
            try
            {
                con.Open();

                cmd.CommandText = "DELETE FROM funcionario WHERE id = @id";
                cmd = new SqlCommand(cmd.CommandText, con);

                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

                System.Windows.Forms.MessageBox.Show("Funcionário deletado com sucesso!", "Sucesso!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                                
            }
            catch(SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable listarCargoComboBox()
        {
            try
            {
                con.Open();

                cmd.CommandText = "SELECT * FROM cargo ORDER BY cargo";

                SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con);
                DataTable tabela = new DataTable();

                da.Fill(tabela);

                return tabela;

            }
            catch(SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return null;
        }

        public DataTable listarFuncionarioByNome(string nome)
        {
            try
            {
                con.Open();

                cmd.CommandText = "";

                SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con);
                DataTable tabela = new DataTable();

                da.Fill(tabela);

                return tabela;
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                con.Close();
            }
            return null; 
        }

    }
}
