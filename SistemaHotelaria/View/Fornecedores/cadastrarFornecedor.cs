using SistemaHotelaria.DAO;
using SistemaHotelaria.Model;
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
    public partial class cadastrarFornecedor : Form
    {
        FornecedorDAO fornecedorDAO = new FornecedorDAO();
        Fornecedor fornecedor = new Fornecedor();

        public cadastrarFornecedor()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            fornecedor.NomeFantasia = txtNomeFantasia.Text;
            fornecedor.RazaoSocial = txtRazaoSocial.Text;
            fornecedor.Endereco = txtEndereco.Text;
            fornecedor.Cnpj = txtCnpj.Text;
            fornecedor.Email = txtEmail.Text;
            fornecedor.Telefone = mskTelefone.Text;
            fornecedor.Categoria = Convert.ToString(cmbCategoria.SelectedItem);

            fornecedorDAO.cadastrarFornecedor(fornecedor);
            this.Close();
        }

        private void cadastrarFornecedor_Load(object sender, EventArgs e)
        {

        }
    }
}
