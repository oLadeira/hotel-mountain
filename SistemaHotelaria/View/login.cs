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

//using SistemaHotelaria.DAO;


namespace SistemaHotelaria
{
    public partial class login : Form
    {
        DAO.LoginDAO loginDAO = new DAO.LoginDAO();

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
            if (txtUsuario.Text == "" && txtSenha.Text == "")
            {
                MessageBox.Show("Insira as informações de login!");
            }
            else
            {
                if (loginDAO.realizaLogin(txtUsuario.Text, txtSenha.Text) == false)
                {
                    MessageBox.Show("Usuário não encontrado, verifique login e senha", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Logado com sucesso!", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    menu TelaMenu = new menu();
                    TelaMenu.Show();
                    this.Hide();
                }

            }

            /*
            Controle controle = new Controle(); //instanciando classe controle

            controle.acessar(txtUsuario.Text, txtSenha.Text); //acessando metodo acessar da classe controle passando como parametros os dados das caixas de textos

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
            */
        }

        private void btnAcesso_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuário: root \nSenha: 123", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
