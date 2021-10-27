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
    public partial class opcoesCheckout : Form
    {
        public opcoesCheckout()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            pesquisarCheckin TelaPesquisarCheckin = new pesquisarCheckin();
            TelaPesquisarCheckin.Show();
            this.Close();
        }
    }
}
