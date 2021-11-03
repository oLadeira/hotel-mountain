using SistemaHotelaria.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotelaria.View
{
    public partial class excluirHospede : Form
    {
        public excluirHospede()
        {
            InitializeComponent();
        }

        private void dgvHospedes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void excluirHospede_Load(object sender, EventArgs e)
        {
            HospedeDAO hospedeDAO = new HospedeDAO();
            dgvHospedes.DataSource = hospedeDAO.listarHospedes();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Insira o id do Hóspede!");
            }
            else
            {
                excluirHospedeForm TelaExcluirHospedeForm = new excluirHospedeForm(Convert.ToInt32(txtId.Text));
                TelaExcluirHospedeForm.Show();
                this.Close();
            }            
        }
    }
}
