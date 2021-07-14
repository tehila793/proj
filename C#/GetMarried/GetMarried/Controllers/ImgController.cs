using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace GetMarried.Controllers
{
    public class ImgController : ApiController
    {
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        // GET: api/Img
        [HttpGet]
        [Route("api/Img/GetAllImg")]
        public List<Dto.ImgDto> GetAllImg()
        {
            return Bll.ImgBll.GetAllImg();
        }

        // GET: api/Img/5
        [HttpGet]
        [Route("api/Img/GetImgById/{id}")]
        public Dto.ImgDto GetImgById(int id)
        {
            return Bll.ImgBll.GetImgById(id);
        }

        // POST: api/Img
        [HttpPost]
        [Route("api/Img/PostImg")]
        public void PostImg(Dto.ImgDto img)
        {
            Bll.ImgBll.PostImg(img);
        }

        // PUT: api/Img/5
        [HttpPut]
        [Route("api/Img/PutImg")]
        public void PutImg(Dto.ImgDto img)
        {
            Bll.ImgBll.PutImg(img);
        }



        // DELETE: api/Img/5
        [HttpDelete]
        [Route("api/Img/DeleteImg/{id}")]
        public void DeleteImg(int id)
        {
            Bll.ImgBll.DeleteImg(id);
        }
    }
    
}
