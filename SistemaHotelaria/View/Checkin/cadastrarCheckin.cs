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
using SistemaHotelaria.Model;
using SistemaHotelaria.DAO;

namespace SistemaHotelaria.View.Checkin
{
    public partial class cadastrarCheckin : Form
    {
        Check_in checkin = new Check_in();
        CheckinDAO checkinDAO = new CheckinDAO();

        public cadastrarCheckin()
        {
            InitializeComponent();
        }

        private void cadastrarCheckin_Load(object sender, EventArgs e)
        {
            QuartoDAO quartoDAO = new QuartoDAO();

            cmbQuarto.DataSource = quartoDAO.listarQuartoComboBox();
            cmbQuarto.ValueMember = "id";
            cmbQuarto.DisplayMember = "numero";

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dtpEntrada.Value.ToString("dd/MM/yyyy"));
            int teste = Convert.ToInt32(dtpEntrada.Value.ToString("dd"));           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(checkin.Entrada.ToString("dd/MM/yyyy"));
            MessageBox.Show(checkin.Dias.ToString());
        }

        private void cmbQuarto_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dtpSaida_ValueChanged(object sender, EventArgs e)
        {
            checkin.Entrada = Convert.ToDateTime(dtpEntrada.Value.ToString());
            checkin.Saida = Convert.ToDateTime(dtpSaida.Value.ToString());

            checkin.Dias = Convert.ToInt32(checkin.Saida.ToString("dd")) - Convert.ToInt32(checkin.Entrada.ToString("dd"));

            txtDias.Text = checkin.Dias.ToString();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            checkin.CpfHospede = txtCpf.Text;
            checkin.IdQuarto = Convert.ToInt32(cmbQuarto.SelectedValue.ToString());          
            checkin.Entrada = Convert.ToDateTime(dtpEntrada.Value.ToString());
            checkin.Saida = Convert.ToDateTime(dtpSaida.Value.ToString());

            checkin.Dias = Convert.ToInt32(checkin.Saida.ToString("dd")) - Convert.ToInt32(checkin.Entrada.ToString("dd"));
                        

            checkinDAO.cadastrarCheckin(checkin);

            System.Windows.Forms.MessageBox.Show("Check-In cadastrado com sucesso!", "Sucesso!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);

            if (Convert.ToInt32(checkin.Dias.ToString()) <= 0)
            {
                MessageBox.Show("Digite uma data de entrada e saída válida!");
            }
            else
            {

            }
            
        }
    }
}
