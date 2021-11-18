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
    public partial class excluirFornecedorForm : Form
    {
        int id;
        DAO.FornecedorDAO fornecedorDAO = new DAO.FornecedorDAO();
        Model.Fornecedor fornecedor = new Model.Fornecedor();

        public excluirFornecedorForm()
        {
            InitializeComponent();
        }

        public excluirFornecedorForm(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void excluirFornecedorForm_Load(object sender, EventArgs e)
        {
            txtNomeFantasia.Enabled = false;
            txtRazaoSocial.Enabled = false;
            txtEndereco.Enabled = false;
            txtCnpj.Enabled = false;
            txtEmail.Enabled = false;
            mskTelefone.Enabled = false;

            fornecedorDAO.dadosAlterar(id, fornecedor);

            txtNomeFantasia.Text = fornecedor.NomeFantasia;
            txtRazaoSocial.Text = fornecedor.RazaoSocial;
            txtEndereco.Text = fornecedor.Endereco;
            txtCnpj.Text = fornecedor.Cnpj;
            txtEmail.Text = fornecedor.Email;
            mskTelefone.Text = fornecedor.Telefone;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            fornecedorDAO.deletarFornecedorById(id);
            this.Close();
        }
    }
}
