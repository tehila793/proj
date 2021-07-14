using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace GetMarried.Controllers
{
    public class OpinionController : ApiController
    {
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        // GET: api/Opinion
        [HttpGet]
        [Route("api/Opinion/GetAllOpinion")]
        public List<Dto.OpinionDto> GetAllOpinion()
        {
            return Bll.OpinionBll.GetAllOpinion();
        }

        // GET: api/Opinion/5
        [HttpGet]
        [Route("api/Opinion/GetOpinionaById/{id}")]
        public Dto.OpinionDto GetOpinionById(int id)
        {
            return Bll.OpinionBll.GetOpinionById(id);
        }

        // POST: api/Opinion
        [HttpPost]
        [Route("api/Opinion/PostOpinion")]
        public void PostArea(Dto.OpinionDto Opinion)
        {
            Bll.OpinionBll.PostOpinion(Opinion);
        }

        // PUT: api/Opinion/5
        [HttpPut]
        [Route("api/PutOpinion/PutOpinion")]
        public void PutOpinion(Dto.OpinionDto Opinion)
        {
            Bll.OpinionBll.PutOpinion(Opinion);
        }

        // DELETE: api/Opinion/5
        [HttpDelete]
        [Route("api/Opinion/DeleteOpinion/{id}")]
        public void DeleteOpinion(int id)
        {
            Bll.OpinionBll.DeleteOpinion(id);
        }
    }
}
