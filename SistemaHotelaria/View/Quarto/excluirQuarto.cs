using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotelaria.View.Quarto
{
    public partial class excluirQuarto : Form
    {
        DAO.QuartoDAO quartoDAO = new DAO.QuartoDAO();

        public excluirQuarto()
        {
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            excluirQuartoForm TelaExcluirQuartoForm = new excluirQuartoForm(Convert.ToInt32(txtId.Text));
            TelaExcluirQuartoForm.Show();
            this.Close();
        }

        private void excluirQuarto_Load(object sender, EventArgs e)
        {
            dgvQuartos.DataSource = quartoDAO.listarQuarto();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
