using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestApi2.Models;

namespace TestApi2.Controllers
{
    public class CursosController : ApiController
    {
        public IEnumerable<curso> GetCursos()
        {
            using (ApiModel modelsWS = new ApiModel())
            {
                return modelsWS.cursos.ToList();
            }
        }

        /*public curso GetCursos(int id)
        {
            if (id != null)
            {
                using (Api modelsWS = new Api())
                {
                    return modelsWS.cursos.ToList().Where(x => x.id == id).FirstOrDefault();
                }
            }
            else
            {
                return new curso();
            }
        }*/
    }
}
