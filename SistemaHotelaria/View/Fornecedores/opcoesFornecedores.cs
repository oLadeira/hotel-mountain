using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotelaria.View.Fornecedores
{
    public partial class opcoesFornecedores : Form
    {
        public opcoesFornecedores()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            cadastrarFornecedor TelaCadastrarFornecedor = new cadastrarFornecedor();
            TelaCadastrarFornecedor.Show();
            this.Close();
        }
    }
}
