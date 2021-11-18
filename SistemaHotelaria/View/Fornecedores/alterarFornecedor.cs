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
    public partial class alterarFornecedor : Form
    {
        DAO.FornecedorDAO fornecedorDAO = new DAO.FornecedorDAO();

        public alterarFornecedor()
        {
            InitializeComponent();
        }

        private void alterarFornecedor_Load(object sender, EventArgs e)
        {
            dgvFornecedores.DataSource = fornecedorDAO.listarFornecedores();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Insira o id do fornecedor!");
            }
            else
            {
                if (fornecedorDAO.validarFornecedor(Convert.ToInt32(txtId.Text)) == false)
                {

                }
                else
                {
                    alterarFornecedorForm TelaAlterarFornecedorForm = new alterarFornecedorForm(Convert.ToInt32(txtId.Text));

                    TelaAlterarFornecedorForm.Show();
                    this.Close();
                }

            }             
                        
        }
    }
}
