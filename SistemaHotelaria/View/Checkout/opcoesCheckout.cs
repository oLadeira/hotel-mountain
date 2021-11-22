using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotelaria.View.Checkout
{
    public partial class opcoesCheckout : Form
    {
        DAO.CheckoutDAO checkOutDAO = new DAO.CheckoutDAO();
        public opcoesCheckout()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            pesquisarCheckin TelaPesquisarCheckin = new pesquisarCheckin();
            TelaPesquisarCheckin.Show();
            this.Close();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            dgvCheckOut.DataSource = checkOutDAO.listarCheckOut();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgvCheckOut.DataSource = checkOutDAO.listarCheckoutCpf(txtCpf.Text);
        }
    }
}
