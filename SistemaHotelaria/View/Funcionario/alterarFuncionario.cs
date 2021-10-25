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
        public alterarFuncionario()
        {
            InitializeComponent();
        }

        private void dgvFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void alterarFuncionario_Load(object sender, EventArgs e)
        {
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();

            dgvFuncionario.DataSource = funcionarioDAO.listarFuncionarios();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                alterarFuncionarioForm TelaAlterarFuncionarioForm = new alterarFuncionarioForm(Convert.ToInt32(txtId.Text));

                TelaAlterarFuncionarioForm.Show();
                this.Close();
            }
            catch(System.FormatException ex)
            {
                MessageBox.Show("Por favor digite um ID válido!", "Erro", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }                           
        }
    }
}
