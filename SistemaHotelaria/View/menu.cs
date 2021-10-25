﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaHotelaria.forms;
using SistemaHotelaria.View;
using SistemaHotelaria.View.Checkin;
using SistemaHotelaria.View.Quarto;

namespace SistemaHotelaria
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void tipHospedes_Click(object sender, EventArgs e)
        {
            opcoesHospedes TelaOpcoesHosp = new opcoesHospedes();
            TelaOpcoesHosp.Show();
        }

        private void tipFuncionarios_Click(object sender, EventArgs e)
        {
            opcoesFuncionarios TelaOpcoesFunci = new opcoesFuncionarios();
            TelaOpcoesFunci.Show();
        }

        private void tipCheckin_Click(object sender, EventArgs e)
        {
            opcoesCheckin TelaOpcoesCheckin = new opcoesCheckin();
            TelaOpcoesCheckin.Show();
            this.Close();
        }

        private void tipQuartos_Click(object sender, EventArgs e)
        {
            opcoesQuarto TelaOpcoesQuarto = new opcoesQuarto();
            TelaOpcoesQuarto.Show();
            this.Close();
        }
    }
}
