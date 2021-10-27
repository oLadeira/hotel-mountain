using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotelaria.Model
{
    class Produto
    {
        private int id;
        private String nome;
        private String categoria;
        private int quantidade;
        private decimal valorCompra;
        private decimal valorVenda;
        private int fornecedor;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public decimal ValorCompra { get => valorCompra; set => valorCompra = value; }
        public decimal ValorVenda { get => valorVenda; set => valorVenda = value; }
        public int Fornecedor { get => fornecedor; set => fornecedor = value; }
    }
}
