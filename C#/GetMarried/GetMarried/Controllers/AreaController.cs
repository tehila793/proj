using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace GetMarried.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class AreaController : ApiController
    {
        // GET: api/Area
        [HttpGet]
        [Route("api/Area/GetAllArea")]
        public List<Dto.AreaDto> GetAllArea()
        {
            return Bll.AreaBll.GetAllArea();
        }

        // GET: api/Area/5
        [HttpGet]
        [Route("api/Area/GetAreaById/{id}")]
        public Dto.AreaDto GetAreaById(int id)
        {
            return Bll.AreaBll.GetAreaById(id);
        }

        // POST: api/Area
        [HttpPost]
        [Route("api/Area/PostArea")]
        public void PostArea(Dto.AreaDto area)
        {
            Bll.AreaBll.PostArea(area);
        }

        // PUT: api/Area/5
        [HttpPut]
        [Route("api/Area/PutArea")]
        public void PutArea(Dto.AreaDto area)
        {
            Bll.AreaBll.PutArea(area);
        }

       

        // DELETE: api/Area/5
        [HttpDelete]
        [Route("api/Area/DeleteArea/{id}")]
        public void DeleteArea(int id)
        {
            Bll.AreaBll.DeleteArea(id);
        }
    }
}
