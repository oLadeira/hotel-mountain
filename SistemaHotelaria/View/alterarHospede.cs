using SistemaHotelaria.DAO;
using SistemaHotelaria.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotelaria.View
{
    public partial class alterarHospede : Form
    {

        private int id;



        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["StringConexao"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        Hospede hospede = new Hospede();
        

        public alterarHospede()
        {
            InitializeComponent();
        }

        public int Id { get => id; set => id = value; }

        private void alterarHospede_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM hospede";

                SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con);
                DataTable tabela = new DataTable();
                                
                da.Fill(tabela);

                dgvHospedes.DataSource = tabela;
                                
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Id = Convert.ToInt32(txtId.Text);

            HospedeDAO hospedeDAO = new HospedeDAO();          
            hospedeDAO.dadosAlterar(Id, hospede);

            alterarHospedeForm telaAlterarHospedeForm = new alterarHospedeForm(Id);
            telaAlterarHospedeForm.Show();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
                
    }
    
}

