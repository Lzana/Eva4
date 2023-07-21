using M.InteligenteModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.InteligenteModel.DAL
{
    public class MedidoresDALObjetos :IMedidoresDAL
    {

        private static List<Medidores> medidores = new List<Medidores>();

        public void AgregarMedidor(Medidores medidor)
        {
            medidores.Add(medidor);
        }

        public List<Medidores> ObtenerMedidores()
        {
            return medidores;
        }
    }
}
