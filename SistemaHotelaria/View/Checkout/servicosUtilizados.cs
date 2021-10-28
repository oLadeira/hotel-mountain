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
    public partial class servicosUtilizados : Form
    {
        public servicosUtilizados()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            listProdutos.Items.Add(cmbProdutos.Text);
            listQuantidade.Items.Add(numericQuantidade.Value);


            //decimal calculo = Convert.ToDecimal(txtTotal.Text) + Convert.ToDecimal(cmbProdutos.SelectedValue);
                        

            decimal calc = Convert.ToDecimal(cmbProdutos.SelectedValue) * numericQuantidade.Value;

            txtTotal.Text = Convert.ToString(Convert.ToDecimal(txtTotal.Text) + calc);

        }

        private void servicosUtilizados_Load(object sender, EventArgs e)
        {
            ProdutoDAO produtoDAO = new ProdutoDAO();

            cmbProdutos.DataSource = produtoDAO.listarProdutosComboBox();
            cmbProdutos.DisplayMember = "nome";
            cmbProdutos.ValueMember = "valorVenda";

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
