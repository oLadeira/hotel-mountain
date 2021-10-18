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
    public partial class cadastrarFuncionario : Form
    {
        public cadastrarFuncionario()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();

            funcionario.Nome = txtNome.Text;
            funcionario.Email = txtEmail.Text;
            funcionario.Cpf = txtCpf.Text;
            funcionario.Cep = txtCep.Text;
            funcionario.EstadoCivil = cmbEstadoCivil.Text;
            funcionario.Telefone = txtTelefone.Text;
            funcionario.Sexo = gboxSexo.Text;
            funcionario.Endereco = txtEndereco.Text;
            funcionario.Numero = txtNumero.Text;
            funcionario.Cargo = Convert.ToInt32(cmbCargo.SelectedValue.ToString());
            funcionario.Turno = cmbTurno.Text;

            funcionarioDAO.inserirFuncionario(funcionario);
            //hospede.Sexo = gboxSexo.Text;

            //HospedeDAO hospedeDAO = new HospedeDAO();
            //hospedeDAO.cadastrarHospede(hospede);

            this.Close();
        }

        private void cadastrarFuncionario_Load(object sender, EventArgs e)
        {
            FuncionarioDAO funcionarioDAO = new FuncionarioDAO();
            cmbCargo.DataSource = funcionarioDAO.listarCargoComboBox();
            cmbCargo.ValueMember = "id";
            cmbCargo.DisplayMember = "cargo";
        }
    }
}
