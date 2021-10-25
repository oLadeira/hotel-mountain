using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotelaria.View.Quarto
{
    public partial class opcoesQuarto : Form
    {
        public opcoesQuarto()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cadastrarQuarto TelaCadastrarQuarto = new cadastrarQuarto();
            TelaCadastrarQuarto.Show();
            this.Close();
        }
    }
}
