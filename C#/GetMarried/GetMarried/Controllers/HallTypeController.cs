using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace GetMarried.Controllers
{
    public class HallTypeController : ApiController
    {
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        // GET: api/HallTyp
        // GET: api/HallType
        [HttpGet]
        [Route("api/HallType/GetAllHallType")]
        public List<Dto.HallTypeDto> GetAllHallType()
        {
            return Bll.HallTypeBll.GetAllHallType();
        }

        // GET: api/HallType/5
        [HttpGet]
        [Route("api/HallType/GetHallTypeById/{id}")]
        public Dto.HallTypeDto GetHallTypeById(int id)
        {
            return Bll.HallTypeBll.GetHallTypeById(id);
        }



        // POST: api/HallType
        [HttpPost]
        [Route("api/HallType/PostHall")]
        public void PostHall(Dto.HallTypeDto Hall)
        {
            Bll.HallTypeBll.PostHallType(Hall);
        }

        // PUT: api/HallType/5
        [HttpPut]
        [Route("api/HallType/PutHall")]
        public void PutHall(Dto.HallTypeDto hall)
        {
            Bll.HallTypeBll.PutHallType(hall);
        }

        // DELETE: api/HallType/5
        [HttpDelete]
        [Route("api/HallType/DeleteHallType/{id}")]
        public void DeleteHallType(int id)
        {
            Bll.HallTypeBll.DeleteHallType(id);
        }
    }
}
