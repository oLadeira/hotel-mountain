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
    public partial class excluirFuncionario : Form
    {
        FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
        public excluirFuncionario()
        {
            InitializeComponent();
        }

        private void excluirFuncionario_Load(object sender, EventArgs e)
        {
            
            dgvFuncionario.DataSource = funcionarioDAO.listarFuncionarios();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Insira o id do fornecedor!");
            }
            else
            {
                if (funcionarioDAO.validarFuncionario(Convert.ToInt32(txtId.Text)) == false)
                {

                }
                else
                {
                    excluirFuncionarioForm TelaExcluirFuncionario = new excluirFuncionarioForm(Convert.ToInt32(txtId.Text));

                    TelaExcluirFuncionario.Show();
                    this.Close();
                }
            }            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
