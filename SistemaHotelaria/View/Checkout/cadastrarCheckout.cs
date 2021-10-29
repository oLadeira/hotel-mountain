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

namespace SistemaHotelaria.View.Checkout
{
    public partial class cadastrarCheckout : Form
    {
        private String cpf1;
        CheckoutDAO checkoutDAO = new CheckoutDAO();
        Check_in checkin = new Check_in();

        public cadastrarCheckout()
        {
            InitializeComponent();
        }

        public cadastrarCheckout(String cpf)
        {         
            InitializeComponent();
            this.cpf1 = cpf;
        }
                       

        private void cadastrarCheckout_Load(object sender, EventArgs e)
        {                                   
            checkoutDAO.pesquisarCheckin(cpf1, checkin);
            ProdutoDAO produtoDAO = new ProdutoDAO();
            QuartoDAO quartoDAO = new QuartoDAO();

            //Populando comboBox produtos
            cmbProdutos.DataSource = produtoDAO.listarProdutosComboBox();
            cmbProdutos.DisplayMember = "nome";
            cmbProdutos.ValueMember = "valorVenda";

            txtCpf.Text = checkin.CpfHospede;

            txtQuarto.Text = Convert.ToString(checkin.IdQuarto);
            //txtQuarto.Text = Convert.ToString(quartoDAO.listarQuarto(Convert.ToInt32(checkin.IdQuarto)));

            dtpEntrada.Value = checkin.Entrada;
            dtpSaida.Value = checkin.Saida;
            DateTime startTime = dtpEntrada.Value;
            DateTime endTime = dtpSaida.Value;
            TimeSpan duration = new TimeSpan(endTime.Ticks - startTime.Ticks);                  
            txtDias.Text = Convert.ToString(duration.ToString("dd"));
                        

            txtTotal.Text = Convert.ToString(checkoutDAO.calculaTotal(txtCpf.Text) * Convert.ToDecimal(txtDias.Text));

            //Populando comboBox serviços
            cmbServicos.DisplayMember = "Text";
            cmbServicos.ValueMember = "Value";
            var items = new[] {
                new { Text = "", Value = "" },
                new { Text = "Limpeza de Quarto", Value = "200,00" },
                new { Text = "Limpeza Completa", Value = "300,00" }
            };
            cmbServicos.DataSource = items;
        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            servicosUtilizados TelaServicosUtilizados = new servicosUtilizados();
            TelaServicosUtilizados.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            listProdutos.Items.Add(cmbProdutos.Text);
            listQuantidade.Items.Add(numericQuantidade.Value);


            //decimal calculo = Convert.ToDecimal(txtTotal.Text) + Convert.ToDecimal(cmbProdutos.SelectedValue);

            decimal calc = Convert.ToDecimal(cmbProdutos.SelectedValue) * numericQuantidade.Value;

            txtTotal.Text = Convert.ToString(Convert.ToDecimal(txtTotal.Text) + calc);
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void numericQuantidade_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAddServico_Click(object sender, EventArgs e)
        {
            listServicos.Items.Add(cmbServicos.Text);

            txtTotal.Text = Convert.ToString(Convert.ToDecimal(txtTotal.Text) + Convert.ToDecimal(cmbServicos.SelectedValue));

            //label13.Text = Convert.ToString(cmbServicos.SelectedValue);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Check_out checkout = new Check_out();
            
            checkout.CpfHosped = txtCpf.Text;
            checkout.IdQuarto = Convert.ToInt32(txtQuarto.Text);
            checkout.Entrada = dtpEntrada.Value;
            checkout.Saida = dtpSaida.Value;
            checkout.Dias = Convert.ToInt32(txtDias.Text);
            checkout.Total = Convert.ToDecimal(txtTotal.Text);

            checkoutDAO.cadastrarCheckout(checkout);
        }
    }
}
