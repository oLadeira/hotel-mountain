using SistemaHotelaria.DAO;
using SistemaHotelaria.Modelo;
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
    public partial class excluirHospedeForm : Form
    {
        int id1;
        HospedeDAO hospedeDAO = new HospedeDAO();
        Hospede hospede = new Hospede();

        public excluirHospedeForm()
        {
            InitializeComponent();
        }

        public excluirHospedeForm(int id)
        {
            InitializeComponent();
            this.id1 = id;
        }

        private void excluirHospedeForm_Load(object sender, EventArgs e)
        {
            txtNome.ReadOnly = true;
            txtTelefone.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtCpf.ReadOnly = true;
            txtCep.ReadOnly = true;
            txtEndereco.ReadOnly = true;
            txtNumero.ReadOnly = true;
            //cmbEstado. = true;
            txtCidade.ReadOnly = true;

            hospedeDAO.dadosAlterar(id1, hospede);

            txtNome.Text = hospede.Nome;
            txtTelefone.Text = hospede.Telefone;
            txtEmail.Text = hospede.Email;
            txtCpf.Text = hospede.Cpf;
            txtCep.Text = hospede.Cep;
            txtEndereco.Text = hospede.Endereco;
            txtNumero.Text = hospede.NumeroEndereco;
            cmbEstado.Text = Convert.ToString(hospede.Estado);
            txtCidade.Text = hospede.Cidade;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            hospedeDAO.deletarHospedeById(id1);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
