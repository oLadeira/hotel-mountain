using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotelaria.Model
{
    class Quarto
    {

        public Quarto()
        {
            this.status = "DISPONIVEL";
        }

        private int id;
        private String categoria;
        private float valor;
        private String numero;
        private String status;

        public int Id { get => id; set => id = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public float Valor { get => valor; set => valor = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Status { get => status; set => status = value; }
    }
}
