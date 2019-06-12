using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Gestor;

namespace PAVCars_webApi.Controllers
{
    public class marcasController : ApiController
    {
        public IHttpActionResult Get()
        {
            return Ok(MarcaDao.ObtenerTodas());
        }
    }
}
