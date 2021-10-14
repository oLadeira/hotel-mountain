using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotelaria.Model
{
    class Funcionario
    {
        private String nome;
        private String email;
        private String cpf;
        private String cep;
        private String estadoCivil;
        private String telefone;
        private String sexo;
        private String endereco;
        private String numero;
        private int cargo;
        private String turno;

        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Cep { get => cep; set => cep = value; }
        public string EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Numero { get => numero; set => numero = value; }
        public int Cargo { get => cargo; set => cargo = value; }
        public string Turno { get => turno; set => turno = value; }
    }
}
