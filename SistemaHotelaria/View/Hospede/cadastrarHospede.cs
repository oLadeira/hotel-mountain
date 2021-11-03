using SistemaHotelaria.DAO;
using SistemaHotelaria.Modelo;
using SistemaHotelaria.ValidacaoCampos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotelaria.forms
{
    public partial class cadastrarHospede : Form
    {        
        
        public cadastrarHospede()
        {
            InitializeComponent();
        }

        private void rbtnMasculino_CheckedChanged(object sender, EventArgs e)
        {    
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {                      
            Hospede hospede = new Hospede();
            Validar validar = new Validar();

            if(validar.validaCamposTexto(txtNome, txtEmail, txtEndereco, txtNumero, txtCidade) == true && (txtCep.MaskCompleted || txtCpf.MaskCompleted || txtTelefone.MaskCompleted) == true)
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
                //hospede.Sexo = gboxSexo.Text;

                HospedeDAO hospedeDAO = new HospedeDAO();
                hospedeDAO.cadastrarHospede(hospede);
            }
            else
            {

            }                           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cadastrarHospede_Load(object sender, EventArgs e)
        {
            HospedeDAO hospedeDAO = new HospedeDAO();

            cmbEstado.DataSource = hospedeDAO.listarEstadoComboBox();
            cmbEstado.ValueMember = "id";
            cmbEstado.DisplayMember = "nome";
        }

    }
}
