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
    public partial class excluirQuartoForm : Form
    {
        int id;
        DAO.QuartoDAO quartoDAO = new DAO.QuartoDAO();
        Model.Quarto quarto = new Model.Quarto();

        public excluirQuartoForm()
        {
            InitializeComponent();
        }

        public excluirQuartoForm(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void excluirQuartoForm_Load(object sender, EventArgs e)
        {
            quartoDAO.dadosAlterar(id, quarto);

            txtCategoria.Text = quarto.Categoria;
            numericNumero.Value = Convert.ToDecimal(quarto.Numero);
            maskValor.Text = Convert.ToString(quarto.Valor);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
