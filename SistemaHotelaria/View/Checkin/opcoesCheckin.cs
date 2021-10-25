using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotelaria.View.Checkin
{
    public partial class opcoesCheckin : Form
    {
        public opcoesCheckin()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cadastrarCheckin TelaCadastrarCheckin = new cadastrarCheckin();
            TelaCadastrarCheckin.Show();
            this.Close();
        }
    }
}
