using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestor
{
    public class MarcaDao
    {
        public static List<Marcas> ObtenerTodas()
        {
            using (PavCarsEntities db = new PavCarsEntities())
            {
                return db.Marcas.OrderBy(x=>x.nombre).ToList();
            }
        }
    }
}
