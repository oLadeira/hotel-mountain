using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaHotelaria.Modelo;

using SistemaHotelaria.DAO;


namespace SistemaHotelaria
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnPular_Click(object sender, EventArgs e)
        {
            menu TelaMenu = new menu();

            TelaMenu.Show();
            this.Hide();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txtUsuario.Text, txtSenha.Text);
            if (controle.mensagem.Equals("")) { 
                if(controle.tem == true)
                {
                    MessageBox.Show("Logado com sucesso!", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    menu TelaMenu = new menu();
                    TelaMenu.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Usuário não encontrado, verifique login e senha", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }
    }
}
