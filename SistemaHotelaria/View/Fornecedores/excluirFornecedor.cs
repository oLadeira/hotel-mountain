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
    public partial class excluirFornecedor : Form
    {
        DAO.FornecedorDAO fornecedorDAO = new DAO.FornecedorDAO();

        public excluirFornecedor()
        {
            InitializeComponent();
        }

        private void excluirFornecedor_Load(object sender, EventArgs e)
        {
            dgvFornecedores.DataSource =  fornecedorDAO.listarFornecedores();
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
                    excluirFornecedorForm TelaExcluirFornecedorForm = new excluirFornecedorForm(Convert.ToInt32(txtId.Text));
                    TelaExcluirFornecedorForm.Show();
                    this.Close();
                }

            }
        }
    }
}
