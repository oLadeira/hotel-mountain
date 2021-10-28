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

namespace SistemaHotelaria.View.Servicos
{
    public partial class cadastrarServico : Form
    {
        public cadastrarServico()
        {
            InitializeComponent();
        }

        private void cadastrarServico_Load(object sender, EventArgs e)
        {
            ProdutoDAO produtoDAO = new ProdutoDAO();
            cmbFornecedor.DataSource = produtoDAO.listarFornecedoresComboBox();
            cmbFornecedor.DisplayMember = "nomeFantasia";
            cmbFornecedor.ValueMember = "id";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            ProdutoDAO produtoDAO = new ProdutoDAO();

            produto.Nome = txtNome.Text;
            produto.Categoria = cmbCategoria.Text;
            produto.Quantidade = Convert.ToInt32(numericQuantidade.Value);
            produto.ValorCompra = Convert.ToDecimal(mskCompra.Text);
            produto.ValorVenda = Convert.ToDecimal(mskVenda.Text);
            produto.Fornecedor = Convert.ToInt32(cmbFornecedor.SelectedValue);

            produtoDAO.cadastrarProduto(produto);

        }
    }
}
