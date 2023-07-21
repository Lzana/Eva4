using M.InteligenteModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.InteligenteModel.DAL
{
    public class tipoMedidoresDALObjetos : ItipoMedidoresDAL
    {
        public List<TipoMedidores> ObtenerTipoMedidores()
        {
            return new List<TipoMedidores>()
            {

                 new TipoMedidores()
                {
                    Nombre = "Automatico",
                    Codigo = "AU"
                },
                new TipoMedidores()
                {
                    Nombre = "Manual",
                    Codigo = "MA"
                }
            };
        }
    }
}
