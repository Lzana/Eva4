using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eva4Model.DAL
{
    public class MedidorDALDB : IMedidorDAL
    {
        private MedidorDBEntities medidorDB = new MedidorDBEntities();
        public void AgregarMedidor(Medidor medidor)
        {
            this.medidorDB Medidor.Add(medidor);
            this.medidorDB.SaveChanges();
        }

        public void EliminarMedidor (int id)
        {

            Medidor medidor = this.medidorDB.Medidor.Find(id);
            this.medidorDB.Medidor.Remove(medidor);
            this.medidorDB.SaveChanges();
        }

        public Medidor Obtener(int id)
        {
            return this.medidorDB.Medidor.Find(id);
        }

        public List<Medidor> ObtenerAsistentes()
        {
            return this.medidorDB.Medidor.ToList();
        }

        public void Actualizar(Medidor a)
        {
            Medidor aOriginal = this.medidorDB.Medidor.Find(a.Id);
            aOriginal.Nombre = a.Nombre;
            aOriginal.Apellido = a.Apellido;
            aOriginal.Edad = a.Edad;
            this.medidorDB.SaveChanges();
        }

        public List<Medidor> ObtenerAsistentes(string estado)
        {
            //LINQ
            var query = from a in this.medidorDB.Medidor
                        where a.Estado == estado
                        select a;
            return query.ToList();
        }

      
    }
}
