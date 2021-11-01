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

namespace SistemaHotelaria.View.Checkout
{
    public partial class pesquisarCheckin : Form
    {
        CheckoutDAO checkoutDAO = new CheckoutDAO();
        Model.Check_in checkin = new Model.Check_in();
        public pesquisarCheckin()
        {
            InitializeComponent();
        }

        private void pesquisarCheckin_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if(checkoutDAO.pesquisarCheckin(txtCpf.Text, checkin) == null)
            {

            }                        
            else
            {
                cadastrarCheckout TelaCadastrarCheckout = new cadastrarCheckout(txtCpf.Text);
                TelaCadastrarCheckout.Show();
                this.Close();
            }           
        }
    }
}
