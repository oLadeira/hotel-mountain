using System;
using System.Windows.Forms;
using SistemaHotelaria.DAO;
using SistemaHotelaria.View;

namespace SistemaHotelaria.forms
{
    public partial class opcoesHospedes : Form
    {              
        
        public opcoesHospedes()
        {
            InitializeComponent();
        }

        private void btnCadastrarHospede_Click(object sender, EventArgs e)
        {          
            cadastrarHospede TelaCadastroHosp = new cadastrarHospede();

            TelaCadastroHosp.Show();
            this.Hide();            
        }
                

        private void btnVisualizarHospede_Click_1(object sender, EventArgs e)
        {
            HospedeDAO hospedeDAO = new HospedeDAO();
            dgvHospedes.DataSource = hospedeDAO.listarHospedes();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            alterarHospede TelaAlterarHospede = new alterarHospede();
            TelaAlterarHospede.Show();
            this.Close();
        }                            

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            excluirHospede TelaAlterarHospede = new excluirHospede();
            TelaAlterarHospede.Show();
            this.Close();
        }

        private void opcoesHospedes_Load(object sender, EventArgs e)
        {
            dgvHospedes.AutoGenerateColumns = false;
        }
    }
}
