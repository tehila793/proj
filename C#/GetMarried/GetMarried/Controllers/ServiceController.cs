using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace GetMarried.Controllers
{
    public class ServiceController : ApiController
    {
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        // GET: api/Service
        [HttpGet]
        [Route("api/Service/GetAllServices")]
        public List<Dto.ServiceDto> GetAllServices()
        {
            return Bll.ServiceBll.GetAllServices();
        }

        // GET: api/Service/5
        [HttpGet]
        [Route("api/Service/GetServiceaById/{id}")]
        public Dto.ServiceDto GetServiceById(int id)
        {
            return Bll.ServiceBll.GetServiceById(id);
        }

        // POST: api/Service
        [HttpPost]
        [Route("api/Service/PostService")]
        public void PostService(Dto.ServiceDto service)
        {
            Bll.ServiceBll.PostService(service);
        }

        // PUT: api/Service/5
        [HttpPut]
        [Route("api/Service/PutService")]
        public void PutService(Dto.ServiceDto Service)
        {
            Bll.ServiceBll.PutService(Service);
        }

        // DELETE: api/Service/5
        [HttpDelete]
        [Route("api/Service/DeleteService/{id}")]
        public void DeleteService(int id)
        {
            Bll.ServiceBll.DeleteService(id);
        }
    }
}
