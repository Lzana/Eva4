using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.InteligenteModel.DTO
{
    public class Lectura
    {
        private Medidores medidores;
        private DateTime fechaL;
        private string horaL;
        private decimal valorConsumo;

        public Medidores Medidores { get => medidores; set => medidores = value; }
        public DateTime FechaL { get => fechaL; set => fechaL = value; }
        public string HoraL { get => horaL; set => horaL = value; }
        public decimal ValorConsumo { get => valorConsumo; set => valorConsumo = value; }
    }
}
