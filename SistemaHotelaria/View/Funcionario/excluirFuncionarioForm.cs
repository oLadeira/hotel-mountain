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
    public partial class excluirFuncionarioForm : Form
    {

        int id1;

        Funcionario funcionario = new Funcionario();
        FuncionarioDAO funcionarioDAO = new FuncionarioDAO();

        public excluirFuncionarioForm()
        {
            InitializeComponent();
        }

        public excluirFuncionarioForm(int id)
        {
            InitializeComponent();
            this.id1 = id;
        }

        private void excluirFuncionarioForm_Load(object sender, EventArgs e)
        {
            funcionarioDAO.dadosAlterar(id1, funcionario);

            txtNome.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtCpf.ReadOnly = true;
            txtCep.ReadOnly = true;
            //cmbEstadoCivil.Text = true;
            txtTelefone.ReadOnly = true;
            txtEndereco.ReadOnly = true;
            txtNumero.ReadOnly = true;
            //cmbCargo.Text = Convert.ToString(funcionario.Cargo);
            //cmbTurno.Text = funcionario.Turno;


            txtNome.Text = funcionario.Nome;
            txtEmail.Text = funcionario.Email;
            txtCpf.Text = funcionario.Cpf;
            txtCep.Text = funcionario.Cep;
            cmbEstadoCivil.Text = funcionario.EstadoCivil;
            txtTelefone.Text = funcionario.Telefone;
            txtEndereco.Text = funcionario.Endereco;
            txtNumero.Text = funcionario.Numero;
            cmbCargo.Text = Convert.ToString(funcionario.Cargo);
            cmbTurno.Text = funcionario.Turno;

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            funcionario.Nome = txtNome.Text;
            funcionario.Email = txtEmail.Text;
            funcionario.Cpf = txtCpf.Text;
            funcionario.Cep = txtCep.Text;
            funcionario.EstadoCivil = cmbEstadoCivil.Text;
            funcionario.Telefone = txtTelefone.Text;
            funcionario.Endereco = txtEndereco.Text;
            funcionario.Numero = txtNumero.Text;
            funcionario.Cargo = Convert.ToInt32(cmbCargo.Text);
            funcionario.Turno = cmbTurno.Text;

            funcionarioDAO.deletarFuncionarioById(id1);

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
