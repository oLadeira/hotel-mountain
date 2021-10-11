using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaHotelaria.forms;

namespace SistemaHotelaria.forms
{
    public partial class opcoesHospedes : Form
    {
        public opcoesHospedes()
        {
            InitializeComponent();
        }

        private void btnCadastrarHospede_Click(object sender, EventArgs e)
        {          
            cadastrarHospede TelaCadastroHosp = new cadastrarHospede();

            TelaCadastroHosp.Show();
            this.Hide();            
        }

        private void btnVisualizarHospede_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
