using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaHotelaria.DAO;

namespace SistemaHotelaria.Modelo
{
    public class Controle
    {
        public bool tem;
        public String mensagem = "";


        public bool acessar(String login, String senha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos(); //instanciando 
            tem = loginDao.verificarLogin(login, senha);
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem; 
            }
            return tem;
        }

    }
}
