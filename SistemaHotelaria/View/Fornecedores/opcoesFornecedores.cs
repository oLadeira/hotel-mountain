using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotelaria.View.Fornecedores
{
    public partial class opcoesFornecedores : Form
    {
        DAO.FornecedorDAO fornecedorDAO = new DAO.FornecedorDAO();
        public opcoesFornecedores()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cadastrarFornecedor TelaCadastrarFornecedor = new cadastrarFornecedor();
            TelaCadastrarFornecedor.Show();
            this.Close();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            dgvFornecedores.DataSource = fornecedorDAO.listarFornecedores();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            alterarFornecedor TelaAlterarFornecedor = new alterarFornecedor();
            TelaAlterarFornecedor.Show();
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            excluirFornecedor TelaExcluirFornecedor = new excluirFornecedor();
            TelaExcluirFornecedor.Show();
            this.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgvFornecedores.DataSource = fornecedorDAO.listarFornecedorNome(txtPesquisar.Text);
        }
    }
}
