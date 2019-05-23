using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using API.Models;
namespace API.Controllers
{
    public class CursosInfoController : ApiController
    {
        public IEnumerable<curso> GetCursos()
        {
            using (Api modelsWS = new Api())
            {
                return modelsWS.cursos.ToList();
            }
        }

        public curso GetCursos(int id)
        {
            if(id != null)
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
        }
    }
}