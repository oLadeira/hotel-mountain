using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHotelaria.ValidacaoCampos
{
    class Validar
    {                

        public bool validaCamposTexto(Control controle, Control controle1, Control controle2, Control controle3, Control controle4)
        {
            if (controle.Text == "" || controle1.Text == "" || controle2.Text == "" || controle3.Text == "" || controle4.Text == "")
            {
                MessageBox.Show("Campos obrigatórios não preenchidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;                
            }
            return true;
        }        
               

    }
}
