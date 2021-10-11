using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotelaria.Modelo
{
    class Hospede
    {
        private String nome;
        private String estadoCivil;
        private String telefone;
        private String email;
        private String cpf;
        private String cep;
        private String endereco;
        private String numeroEndereco;
        private String estado;
        private String cidade;
        //private String sexo;

        public Hospede()
        {
        }

        public string Nome { get => nome; set => nome = value; }
        public string EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string NumeroEndereco { get => numeroEndereco; set => numeroEndereco = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Cidade { get => cidade; set => cidade = value; }
       //public string Sexo { get => sexo; set => sexo = value; }
    }
}
