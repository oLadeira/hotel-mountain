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
    public partial class alterarFuncionario : Form
    {
        FuncionarioDAO funcionarioDAO = new FuncionarioDAO();

        public alterarFuncionario()
        {
            InitializeComponent();
        }

        private void dgvFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void alterarFuncionario_Load(object sender, EventArgs e)
        {          
            dgvFuncionario.DataSource = funcionarioDAO.listarFuncionarios();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {          
            if (txtId.Text == "")
            {
                MessageBox.Show("Insira o id do funcionário!");
            }
            else
            {
                if (funcionarioDAO.validarFuncionario(Convert.ToInt32(txtId.Text)) == false)
                {

                }
                else
                {
                    alterarFuncionarioForm TelaAlterarFuncionarioForm = new alterarFuncionarioForm(Convert.ToInt32(txtId.Text));

                    TelaAlterarFuncionarioForm.Show();
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
