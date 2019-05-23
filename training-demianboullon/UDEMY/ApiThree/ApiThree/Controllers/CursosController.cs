using ApiThree.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiThree.Controllers
{
    public class CursosInfoController : ApiController
    {
        public IEnumerable<curso> GetCursos()
        {
            using (var ORGWSModel = new ApiModels())
            {
                return ORGWSModel.cursos.ToArray();
            }
        }

        public IEnumerable<curso> GetCursos(int id)
        {
            using (var ORGWSModel = new ApiModels())
            {
                return ORGWSModel.cursos.ToArray().Where(x => x.id == id);
            }
        }
    }
}
