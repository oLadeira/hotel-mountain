using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaHotelaria.Model
{
    class Check_out
    {
        private int id;
        private String cpfHosped;
        private int idQuarto;
        private DateTime entrada;
        private DateTime saida;
        private int dias;
        private float total;

        public int Id { get => id; set => id = value; }
        public string CpfHosped { get => cpfHosped; set => cpfHosped = value; }
        public int IdQuarto { get => idQuarto; set => idQuarto = value; }
        public DateTime Entrada { get => entrada; set => entrada = value; }
        public DateTime Saida { get => saida; set => saida = value; }
        public int Dias { get => dias; set => dias = value; }
        public float Total { get => total; set => total = value; }
    }
}
