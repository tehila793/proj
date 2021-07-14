using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace GetMarried.Controllers
{
    public class HallsController : ApiController
    {
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        // GET: api/Halls
        [HttpGet]
        [Route("api/Halls/GetAllHalls")]
        public List<Dto.HallsDto> GetAllHalls()
        {
            return Bll.HallsBll.GetAllHalls();
        }

        // GET: api/Halls/5
        [HttpGet]
        [Route("api/Halls/GetHallById/{id}")]
        public Dto.HallsDto GetHallById(int id)
        {
            return Bll.HallsBll.GetHallById(id);
        }



        // POST: api/Halls
        [HttpPost]
        [Route("api/Halls/PostHall")]
        public void PostHall(Dto.HallsDto Hall)
        {
            Bll.HallsBll.PostHall(Hall);
        }

        // PUT: api/Halls/5
        [HttpPut]
        [Route("api/Halls/PutHall")]
        public void PutHall(Dto.HallsDto hall)
        {
            Bll.HallsBll.PutHall(hall);
        }

        // DELETE: api/Halls/5
        [HttpDelete]
        [Route("api/Halls/DeleteHalls/{id}")]
        public void DeleteHalls(int id)
        {
            Bll.HallsBll.DeleteHall(id);
        }
    }
}
