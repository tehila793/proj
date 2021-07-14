using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dal;
using Dto;

namespace GetMarried.Controllers
{
    public class CategoriesController : ApiController
    {

        [HttpGet]
        [Route("api/Categories/GetAllCategories")]
        public List<Dto.CategoriesDto> GetAllCategories()
        {
            return Bll.CategoriesBll.GetAllCategories();
        }



        // POST: api/Categories
        [HttpGet]
        [Route("api/Categories/Post")]
        public void Post([FromBody] Dal.Categories categories)
        {
            Bll.CategoriesBll.PostCategories(categories);
        }

        // PUT: api/Categories/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Categories/5
        public void Delete(int id)
        {
        }
    }
}
