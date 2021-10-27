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
    public partial class servicosUtilizados : Form
    {
        public servicosUtilizados()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            listProdutos.Items.Add(cmbProdutos.SelectedItem);
            listQuantidade.Items.Add(numericQuantidade.Value);
        }
    }
}
