using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotelaria.View.Checkin
{    
    public partial class excluirCheckin : Form
    {
        DAO.CheckinDAO checkinDAO = new DAO.CheckinDAO();

        public excluirCheckin()
        {
            InitializeComponent();
        }

        private void alterarCheckin_Load(object sender, EventArgs e)
        {
            dgvCheckin.DataSource = checkinDAO.listarCheckin();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
