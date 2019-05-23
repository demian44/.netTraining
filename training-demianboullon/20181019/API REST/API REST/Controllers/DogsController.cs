using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ModelBinding;
using System.Web.Http.OData;
using System.Web.Http.OData.Query;
using System.Web.Http.OData.Routing;
using API_REST.Models;
using Microsoft.Data.OData;

namespace API_REST.Controllers
{
    /*
    The WebApiConfig class may require additional changes to add a route for this 
    controller. Merge these statements into the Register method of the WebApiConfig
    class as applicable. Note that OData URLs are case sensitive.

    using System.Web.Http.OData.Builder;
    using System.Web.Http.OData.Extensions;
    using API_REST.Models;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<Dog>("Dogs");
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class DogsController : ODataController
    {
        private static ODataValidationSettings _validationSettings = new ODataValidationSettings();

        // GET: odata/Dogs
        public Dog GetDogs(ODataQueryOptions<Dog> queryOptions)
        {
            // validate the query.
            //try
            //{
            //    queryOptions.Validate(_validationSettings);
            //}
            //catch (ODataException ex)
            //{
            //    return BadRequest(ex.Message);
            //}

            //// return Ok<IEnumerable<Dog>>(dogs);
            //return StatusCode(HttpStatusCode.NotImplemented);
            return new Dog() { Id = 1, Name = "asd", Age = 1 };
        }

        // GET: odata/Dogs(5)
        public IHttpActionResult GetDog([FromODataUri] int key, ODataQueryOptions<Dog> queryOptions)
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

            // return Ok<Dog>(dog);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // PUT: odata/Dogs(5)
        public IHttpActionResult Put([FromODataUri] int key, Delta<Dog> delta)
        {
            Validate(delta.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Get the entity here.

            // delta.Put(dog);

            // TODO: Save the patched entity.

            // return Updated(dog);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // POST: odata/Dogs
        public IHttpActionResult Post(Dog dog)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Add create logic here.

            // return Created(dog);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // PATCH: odata/Dogs(5)
        [AcceptVerbs("PATCH", "MERGE")]
        public IHttpActionResult Patch([FromODataUri] int key, Delta<Dog> delta)
        {
            Validate(delta.GetEntity());

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // TODO: Get the entity here.

            // delta.Patch(dog);

            // TODO: Save the patched entity.

            // return Updated(dog);
            return StatusCode(HttpStatusCode.NotImplemented);
        }

        // DELETE: odata/Dogs(5)
        public IHttpActionResult Delete([FromODataUri] int key)
        {
            // TODO: Add delete logic here.

            // return StatusCode(HttpStatusCode.NoContent);
            return StatusCode(HttpStatusCode.NotImplemented);
        }
    }
}
