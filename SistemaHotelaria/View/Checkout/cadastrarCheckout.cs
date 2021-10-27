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

namespace SistemaHotelaria.View.Checkout
{
    public partial class cadastrarCheckout : Form
    {
        private String cpf1;
        CheckoutDAO checkoutDAO = new CheckoutDAO();
        Check_in checkin = new Check_in();

        public cadastrarCheckout()
        {
            InitializeComponent();
        }

        public cadastrarCheckout(String cpf)
        {         
            InitializeComponent();
            this.cpf1 = cpf;
        }
                       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            
        }

        private void cadastrarCheckout_Load(object sender, EventArgs e)
        {                                   
            checkoutDAO.pesquisarCheckin(cpf1, checkin);
                       

            txtCpf.Text = checkin.CpfHospede;
            txtQuarto.Text = Convert.ToString(checkin.IdQuarto);
            dtpEntrada.Value = checkin.Entrada;
            dtpSaida.Value = checkin.Saida;
            txtDias.Text = Convert.ToString(checkin.Dias);

            txtTotal.Text = Convert.ToString(checkoutDAO.calculaTotal(txtCpf.Text));
        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            servicosUtilizados TelaServicosUtilizados = new servicosUtilizados();
            TelaServicosUtilizados.Show();
        }
    }
}
