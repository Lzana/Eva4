using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.InteligenteModel.DTO
{
    public  class Medidores
    {
        private string tipo;
        private int serie;

        public string Tipo { get => tipo; set => tipo = value; }
        public int Serie { get => serie; set => serie = value; }

        internal void Add(Medidores medidores)
        {
            throw new NotImplementedException();
        }
    }
}
