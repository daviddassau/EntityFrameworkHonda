using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EntityFrameworkHonda.Models;
using EntityFrameworkHonda.Services;

namespace EntityFrameworkHonda.Controllers
{
    [RoutePrefix("api/civics")]
    public class CivicsController : ApiController
    {
        [Route(""), HttpPost]
        public HttpResponseMessage AddCivic(Civic civic)
        {
            var repository = new CivicRepository();
            var result = repository.Create(civic.Year, civic.Trim, civic.Doors);

            if (result)
            {
                return Request.CreateResponse(HttpStatusCode.Created);
            }

            return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Sorry");
        }
    }
}