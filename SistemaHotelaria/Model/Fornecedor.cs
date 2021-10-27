using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotelaria.Model
{
    class Fornecedor
    {
        private int id;
        private String nomeFantasia;
        private String razaoSocial;
        private String endereco;
        private String cnpj;
        private String email;
        private String telefone;
        private String categoria;

        public int Id { get => id; set => id = value; }
        public string NomeFantasia { get => nomeFantasia; set => nomeFantasia = value; }
        public string RazaoSocial { get => razaoSocial; set => razaoSocial = value; }
        public string Endereco { get => endereco; set => endereco = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string Email { get => email; set => email = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Categoria { get => categoria; set => categoria = value; }
    }
}
