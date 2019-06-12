using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Gestor;

namespace PAVCars_webApi.Controllers
{
    public class autosController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok(AutoDao.ObtenerTodos());
        }
        
        public IHttpActionResult Post(Autos auto)
        {
            try
            {
                AutoDao.Insertar(auto);
                return Ok();
            }
            catch (ApplicationException ex)
            {
                return InternalServerError(ex);                
            }
        }

        public IHttpActionResult Put(Autos auto)
        {
            try
            {
                AutoDao.Actualizar(auto);
                return Ok();
            }
            catch (ApplicationException ex)
            {
                return InternalServerError(ex);
            }
        }

        public IHttpActionResult Delete(int id)
        {
            try
            {
                AutoDao.Eliminar(id);
                return Ok();
            }
            catch (ApplicationException ex)
            {
                return InternalServerError(ex);
            }
        }
    }
}
