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

        private void cmbQuarto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpSaida_ValueChanged(object sender, EventArgs e)
        {
            checkin.Entrada = Convert.ToDateTime(dtpEntrada.Value.ToString());
            checkin.Saida = Convert.ToDateTime(dtpSaida.Value.ToString());

            DateTime startTime = dtpEntrada.Value;
            DateTime endTime = dtpSaida.Value;

            TimeSpan duration = new TimeSpan(endTime.Ticks - startTime.Ticks);

            txtDias.Text = Convert.ToString(duration.ToString(@"dd"));

            checkin.Dias = Convert.ToInt32(checkin.Saida.ToString("dd")) - Convert.ToInt32(checkin.Entrada.ToString("dd"));


            //txtDias.Text = checkin.Dias.ToString();

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            checkin.CpfHospede = txtCpf.Text;
            checkin.IdQuarto = Convert.ToInt32(cmbQuarto.SelectedValue.ToString());
            checkin.Entrada = Convert.ToDateTime(dtpEntrada.Value.ToString());
            checkin.Saida = Convert.ToDateTime(dtpSaida.Value.ToString());

            checkin.Dias = Convert.ToInt32(checkin.Saida.ToString("dd")) - Convert.ToInt32(checkin.Entrada.ToString("dd"));


            checkinDAO.cadastrarCheckin(checkin);


            if (Convert.ToInt32(checkin.Dias.ToString()) <= 0)
            {
                MessageBox.Show("Digite uma data de entrada e saída válida!");
            }
            else
            {

            }

        }

        private void dtpEntrada_ValueChanged(object sender, EventArgs e)
        {

        }               
    }
}
