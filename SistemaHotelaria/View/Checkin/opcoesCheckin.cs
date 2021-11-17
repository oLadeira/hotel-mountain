using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotelaria.View.Checkin
{
    public partial class opcoesCheckin : Form
    {
        DAO.CheckinDAO checkinDAO = new DAO.CheckinDAO();
        public opcoesCheckin()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cadastrarCheckin TelaCadastrarCheckin = new cadastrarCheckin();
            TelaCadastrarCheckin.Show();
            this.Close();
        }

        private void opcoesCheckin_Load(object sender, EventArgs e)
        {

        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            dgvCheckin.DataSource = checkinDAO.listarCheckin();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            alterarCheckin TelaAlterarCheckin = new alterarCheckin();

            TelaAlterarCheckin.Show();

            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }
    }
}
