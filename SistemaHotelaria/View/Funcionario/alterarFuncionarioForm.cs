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

namespace SistemaHotelaria.View
{
    public partial class alterarFuncionarioForm : Form
    {

        int id1;

        FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
        Funcionario funcionario = new Funcionario();

        public alterarFuncionarioForm()
        {
            InitializeComponent();
        }

        public alterarFuncionarioForm(int id)
        {
            InitializeComponent();
            this.id1 = id;
        }

        private void alterarFuncionarioForm_Load(object sender, EventArgs e)
        {            
            funcionarioDAO.dadosAlterar(id1, funcionario);

            txtNome.Text = funcionario.Nome;
            txtEmail.Text = funcionario.Email;
            txtCpf.Text = funcionario.Cpf;
            txtCep.Text = funcionario.Cep;
            cmbEstadoCivil.Text = funcionario.EstadoCivil;
            txtTelefone.Text = funcionario.Telefone;
            txtEndereco.Text = funcionario.Endereco;
            txtNumero.Text = funcionario.Numero;
            cmbTurno.Text = funcionario.Turno;

            cmbCargo.DataSource = funcionarioDAO.listarCargoComboBox();
            cmbCargo.ValueMember = "id";
            cmbCargo.DisplayMember = "cargo";
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            funcionario.Nome = txtNome.Text;
            funcionario.Email = txtEmail.Text;
            funcionario.Cpf = txtCpf.Text;
            funcionario.Cep = txtCep.Text;
            funcionario.EstadoCivil = cmbEstadoCivil.Text;
            funcionario.Telefone = txtTelefone.Text;
            funcionario.Endereco = txtEndereco.Text;
            funcionario.Numero = txtNumero.Text;
            funcionario.Cargo = Convert.ToInt32(cmbCargo.SelectedValue.ToString());
            funcionario.Turno = cmbTurno.Text;

            funcionarioDAO.alterarHospede(id1, funcionario);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
