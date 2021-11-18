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
    public partial class alterarFornecedorForm : Form
    {
        int id1;

        Model.Fornecedor fornecedor = new Model.Fornecedor();
        DAO.FornecedorDAO fornecedorDAO = new DAO.FornecedorDAO();

        public alterarFornecedorForm()
        {
            InitializeComponent();
        }

        public alterarFornecedorForm(int id)
        {
            InitializeComponent();
            this.id1 = id;
        }

        private void alterarFornecedorForm_Load(object sender, EventArgs e)
        {
            fornecedorDAO.dadosAlterar(id1, fornecedor);

            txtNomeFantasia.Text = fornecedor.NomeFantasia;
            txtRazaoSocial.Text = fornecedor.RazaoSocial;
            txtEndereco.Text = fornecedor.Endereco;
            txtCnpj.Text = fornecedor.Cnpj;
            txtEmail.Text = fornecedor.Email;
            mskTelefone.Text = fornecedor.Telefone;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            fornecedor.NomeFantasia = txtNomeFantasia.Text;
            fornecedor.RazaoSocial = txtRazaoSocial.Text;
            fornecedor.Endereco = txtEndereco.Text;
            fornecedor.Cnpj = txtCnpj.Text;
            fornecedor.Email = txtEmail.Text;
            fornecedor.Telefone = mskTelefone.Text;

            fornecedor.Categoria = cmbCategoria.Text;

            fornecedorDAO.alterarFornecedor(id1, fornecedor);
            this.Close();
        }
    }
}
