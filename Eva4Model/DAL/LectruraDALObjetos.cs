using M.InteligenteModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.InteligenteModel.DAL
{
    internal class LectruraDALObjetos :ILecturaDal
    {

        private static List<Lectura> lecturas = new List<Lectura>();
        public void AgregarLectura(Lectura lectura)
        {
            lecturas.Add(lectura);
        }

        public List<Lectura> ObtenerLecturas()
        {
            return lecturas;
        }

    }
}
