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

namespace SistemaHotelaria.View.Quarto
{
    public partial class opcoesQuarto : Form
    {
        QuartoDAO quartoDAO = new QuartoDAO();
        public opcoesQuarto()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cadastrarQuarto TelaCadastrarQuarto = new cadastrarQuarto();
            TelaCadastrarQuarto.Show();
            this.Close();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            dgvQuartos.DataSource = quartoDAO.listarQuarto();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            excluirQuarto TelaExcluirQuarto = new excluirQuarto();
            TelaExcluirQuarto.Show();
            this.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
        }
    }
}
