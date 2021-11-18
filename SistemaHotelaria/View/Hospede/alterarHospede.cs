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

        //public int Id { get => id; set => id = value; }

        private void alterarHospede_Load(object sender, EventArgs e)
        {
            HospedeDAO hospedeDAO = new HospedeDAO();
            dgvHospedes.DataSource = hospedeDAO.listarHospedes();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Insira o id do hóspede!");
            }
            else
            {
                id = Convert.ToInt32(txtId.Text);
            }
            
            HospedeDAO hospedeDAO = new HospedeDAO();

            if(hospedeDAO.validarHospede(id) == false)
            {

            }
            else
            {
                alterarHospedeForm telaAlterarHospedeForm = new alterarHospedeForm(id);
                telaAlterarHospedeForm.Show();
                this.Close();
            }          
                      

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

}

