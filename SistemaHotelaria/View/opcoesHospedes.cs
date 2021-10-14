﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaHotelaria.forms;
using SistemaHotelaria.View;

namespace SistemaHotelaria.forms
{
    public partial class opcoesHospedes : Form
    {

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["StringConexao"].ConnectionString);
        SqlCommand cmd = new SqlCommand();
        
        public opcoesHospedes()
        {
            InitializeComponent();
        }

        private void btnCadastrarHospede_Click(object sender, EventArgs e)
        {          
            cadastrarHospede TelaCadastroHosp = new cadastrarHospede();

            TelaCadastroHosp.Show();
            this.Hide();            
        }

        private void btnVisualizarHospede_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnVisualizarHospede_Click_1(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd.CommandText = "SELECT * FROM hospede";

                SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, con);
                DataTable tabela = new DataTable();

                da.Fill(tabela);

                dgvHospedes.DataSource = tabela;

                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            alterarHospede TelaAlterarHospede = new alterarHospede();
            TelaAlterarHospede.Show();
            this.Close();
        }

        private void dgvHospedes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
