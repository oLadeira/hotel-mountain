using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaHotelaria.DAO;
using SistemaHotelaria.Model;

namespace SistemaHotelaria.View.Quarto
{
    public partial class cadastrarQuarto : Form
    {
        public cadastrarQuarto()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Model.Quarto quarto = new Model.Quarto();
            QuartoDAO quartoDAO = new QuartoDAO();

            quarto.Categoria = cmbCategoria.Text;
            quarto.Valor = float.Parse(maskValor.Text);
            quarto.Numero = Convert.ToString(numericNumero.Value);

            quartoDAO.cadastrarQuarto(quarto);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cadastrarQuarto_Load(object sender, EventArgs e)
        {

        }
    }
}
