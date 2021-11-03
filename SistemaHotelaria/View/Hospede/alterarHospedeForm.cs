using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaHotelaria.DAO;
using SistemaHotelaria.Modelo;
using SistemaHotelaria.View;


namespace SistemaHotelaria.View
{
    public partial class alterarHospedeForm : Form
    {
        private int id1;
        Hospede hospede = new Hospede();
        HospedeDAO hospedeDAO = new HospedeDAO();
        public alterarHospedeForm()
        {
            InitializeComponent();            
        }

        public alterarHospedeForm(int id)
        {
            InitializeComponent();
            id1 = id;
        }

        
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            hospede.Nome = txtNome.Text;
            hospede.Telefone = txtTelefone.Text;
            hospede.Email = txtEmail.Text;
            hospede.Cpf = txtCpf.Text;
            hospede.Cep = txtCep.Text;
            hospede.Endereco = txtEndereco.Text;
            hospede.NumeroEndereco = txtNumero.Text;
            hospede.Estado = Convert.ToInt32(cmbEstado.SelectedValue.ToString());
            hospede.Cidade = txtCidade.Text;

            hospedeDAO.alterarHospede(id1, hospede);
            this.Close();
        }

        private void alterarHospedeForm_Load(object sender, EventArgs e)
        {                      

            hospede = hospedeDAO.dadosAlterar(id1, hospede);

            txtNome.Text = hospede.Nome;
            txtTelefone.Text = hospede.Telefone;
            txtEmail.Text = hospede.Email;
            txtCpf.Text = hospede.Cpf;
            txtCep.Text = hospede.Cep;
            txtEndereco.Text = hospede.Endereco;
            txtNumero.Text = hospede.NumeroEndereco;            
            txtCidade.Text = hospede.Cidade;

            cmbEstado.DataSource = hospedeDAO.listarEstadoComboBox();
            cmbEstado.ValueMember = "id";
            cmbEstado.DisplayMember = "nome";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
