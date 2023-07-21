using M.InteligenteModel.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.InteligenteModel.DAL
{
    public  interface IMedidoresDAL
    {
        List<Medidores> ObtenerMedidores();

        void AgregarMedidor(Medidores medidores);
    }
}
