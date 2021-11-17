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
    public partial class opcoesFuncionarios : Form
    {
        FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
        public opcoesFuncionarios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cadastrarFuncionario TelaCadastrarFuncionario = new cadastrarFuncionario();
            TelaCadastrarFuncionario.Show();
            this.Close();
        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {
            dgvFuncionarios.DataSource = funcionarioDAO.listarFuncionarios();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            alterarFuncionario TelaAlterarFuncionario = new alterarFuncionario();
            TelaAlterarFuncionario.Show();
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            excluirFuncionario TelaExcluirFuncionario = new excluirFuncionario();
            TelaExcluirFuncionario.Show();
            this.Close();
        }

        private void btnPesquisarNome_Click(object sender, EventArgs e)
        {
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
            dgvFuncionarios.DataSource = funcionarioDAO.listarFuncionarioByNome(txtPesquisarNome.Text);
        }
    }
}
