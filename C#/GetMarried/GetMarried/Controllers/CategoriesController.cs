using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Dal;
using Dto;

namespace GetMarried.Controllers
{
    public class CategoriesController : ApiController
    {
        [EnableCors(origins: "*", headers: "*", methods: "*")]

        [HttpGet]
        [Route("api/Categories/GetAllCategories")]
        public List<Dto.CategoriesDto> GetAllCategories()
        {
            return Bll.CategoriesBll.GetAllCategories();
        }

        [HttpGet]
        [Route("api/Categories/GetCategoryById/{id}")]
        public Dto.CategoriesDto GetCategoryById(int id)
        {
            return Bll.CategoriesBll.GetCategoryById(id);
        }


        // POST: api/Categories
        //add
        [HttpPost]
        [Route("api/Categories/PostCategories")]
        public void PostCategories(Dto.CategoriesDto categories)
        {
            Bll.CategoriesBll.PostCategories(categories);
        }


        [HttpPut]
        [Route("api/Categories/PutCategory")]
        public void PutCategory(Dto.CategoriesDto Category)
        {
            Bll.CategoriesBll.PutCategories(Category);
        }


        // DELETE: api/Categories/5
        [HttpDelete]
        [Route("api/Categories/DeleteCategory/{id}")]
        public void DeleteCategory(int id)
        {
            Bll.CategoriesBll.DeleteCategory(id);
        }
    }
}
