using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.Http.OData;
using System.Web.Http.OData.Query;
using System.Web.Http.OData.Routing;
using ProductsApp.Models;
using Microsoft.Data.OData;

namespace ProductsApp.Controllers
{
    /*
    The WebApiConfig class may require additional changes to add a route for this controller. Merge these statements into the Register method of the WebApiConfig class as applicable. Note that OData URLs are case sensitive.

    using System.Web.Http.OData.Builder;
    using System.Web.Http.OData.Extensions;
    using ProductsApp.Models;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<Area>("Areas");
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class AreasController : ODataController
    {
        private static ODataValidationSettings _validationSettings = new ODataValidationSettings();


        public IEnumerable<Area> GetAllProducts()
        {
            AreasAppContext areasAppContext = new AreasAppContext();
            var pepe = areasAppContext.Areas.First();
            return new List<Area>() { new Area()};
        }
        // GET: odata/Areas
       /* public async Task<IHttpActionResult> GetAreas(ODataQueryOptions<Area> queryOptions)
        {
            // validate the query.
            try
            {
                queryOptions.Validate(_validationSettings);
            }
            catch (ODataException ex)
            {
                return BadRequest(ex.Message);
            }

            // return Ok<IEnumerable<Area>>(areas);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // GET: odata/Areas(5)
        public async Task<IHttpActionResult> GetArea([FromODataUri] int key, ODataQueryOptions<Area> queryOptions)
        {
            // validate the query.
            try
            {
                queryOptions.Validate(_validationSettings);
            }
            catch (ODataException ex)
            {
                return BadRequest(ex.Message);
            }

            // return Ok<Area>(area);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // PUT: odata/Areas(5)
        public async Task<IHttpActionResult> Put([FromODataUri] int key, Delta<Area> delta)
        {
            Validate(delta.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Get the entity here.

            // delta.Put(area);

            // TODO: Save the patched entity.

            // return Updated(area);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // POST: odata/Areas
        public async Task<IHttpActionResult> Post(Area area)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Add create logic here.

            // return Created(area);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // PATCH: odata/Areas(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public async Task<IHttpActionResult> Patch([FromODataUri] int key, Delta<Area> delta)
        {
            Validate(delta.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Get the entity here.

            // delta.Patch(area);

            // TODO: Save the patched entity.

            // return Updated(area);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // DELETE: odata/Areas(5)
        public async Task<IHttpActionResult> Delete([FromODataUri] int key)
        {
            // TODO: Add delete logic here.

            // return StatusCode(HttpStatusCode.NoContent);
            return StatusCode(HttpStatusCode.NotImplemented);
        }*/
    }
}
