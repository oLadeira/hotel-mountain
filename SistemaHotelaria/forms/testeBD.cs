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
    public partial class testeBD : Form
    {
        public testeBD()
        {
            InitializeComponent();
        }

        private void testeBD_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'hotelMountainDataSet1.loginFuncionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.loginFuncionariosTableAdapter.Fill(this.hotelMountainDataSet1.loginFuncionarios);
            // TODO: esta linha de código carrega dados na tabela 'hotelMountainDataSet.funcionarioLogin'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionarioLoginTableAdapter.Fill(this.hotelMountainDataSet.funcionarioLogin);

        }
    }
}
