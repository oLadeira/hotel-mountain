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

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
                      
            Hospede hospede = new Hospede();

            hospede.Nome = txtNome.Text;
            hospede.EstadoCivil = cmbEstadoCivil.SelectedItem.ToString();
            hospede.Telefone = txtTelefone.Text;
            hospede.Email = txtEmail.Text;
            hospede.Cpf = txtCpf.Text;
            hospede.Cep = txtCep.Text;
            hospede.Endereco = txtEndereco.Text;
            hospede.NumeroEndereco = txtNumero.Text;
            hospede.Estado = cmbEstado.SelectedItem.ToString();
            hospede.Cidade = txtCidade.Text;
            //hospede.Sexo = gboxSexo.Text;

            HospedeDAO hospedeDAO = new HospedeDAO();
            hospedeDAO.cadastrarHospede(hospede);

            this.Close();           
        }
    }
}
