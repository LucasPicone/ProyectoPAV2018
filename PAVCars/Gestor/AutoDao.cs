using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor
{
    public class AutoDao
    {
        public static List<Autos> Obtener()
        {
            using (PavCarsEntities db = new PavCarsEntities())
            {
                return db.Autos.ToList();
            }
        }

        public static Autos Obtener(long id)
        {
            using (PavCarsEntities db = new PavCarsEntities())
            {
                var auto = (from aut in db.Autos where aut.id == id select aut).FirstOrDefault();
                return auto;
            }
        }

        public static List<Autos> Obtener(string cadena)
        {
            using (PavCarsEntities db = new PavCarsEntities())
            {
                var auto = (from aut in db.Autos where aut.modelo.StartsWith(cadena) select aut).ToList();
                return auto;
            }
        }

        public static void Insertar(Autos auto)
        {
            using (PavCarsEntities db = new PavCarsEntities())
            {
                try
                {
                    db.Autos.Add(auto);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("cod_chasis ya esta usado");
                }
            }
        }

        public static void Actualizar(Autos auto)
        {
            using (PavCarsEntities db = new PavCarsEntities())
            {
                try
                {
                    var au = (from aut in db.Autos where aut.id == auto.id select aut).FirstOrDefault();
                    db.Entry(au).CurrentValues.SetValues(auto);
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("cod_chasis ya esta usado");
                }
            }
        }

        public static void Eliminar(long id)
        {
            using (PavCarsEntities db = new PavCarsEntities())
            {
                try
                {
                    Autos auto = Obtener(id);
                    db.Entry(auto).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new ApplicationException("Error al eliminar el auto");
                }
            }
        }
    }
}
