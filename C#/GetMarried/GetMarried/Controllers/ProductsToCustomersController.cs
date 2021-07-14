using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace GetMarried.Controllers
{
    public class ProductsToCustomersController : ApiController
    {
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        // GET: api/ProductsToCustomers
        [HttpGet]
        [Route("api/Area/GetAllProductsToCustomers")]
        public List<Dto.ProductsToCustomersDto> GetAllProductsToCustomers()
        {
            return Bll.ProductsToCustomersBll.GetAllProductsToCustomers();
        }

        // GET: api/ProductsToCustomers/5
        [HttpGet]
        [Route("api/ProductsToCustomers/GetProductsToCustomersById/{id}")]
        public Dto.ProductsToCustomersDto GetProductsToCustomersById(int id)
        {
            return Bll.ProductsToCustomersBll.GetProductsToCustomersById(id);
        }

        // POST: api/ProductsToCustomers
        [HttpPost]
        [Route("api/ProductsToCustomers/PostProductsToCustomers")]
        public void PostProductsToCustomers(Dto.ProductsToCustomersDto ProductsToCustomers)
        {
            Bll.ProductsToCustomersBll.PostProductsToCustomers(ProductsToCustomers);
        }

        // PUT: api/ProductsToCustomers/5
        [HttpPut]
        [Route("api/ProductsToCustomers/PutProductsToCustomers")]
        public void PutProductsToCustomers(Dto.ProductsToCustomersDto ProductsToCustomers)
        {
            Bll.ProductsToCustomersBll.PutProductsToCustomers(ProductsToCustomers);
        }

        // DELETE: api/ProductsToCustomers/5
        [HttpDelete]
        [Route("api/ProductsToCustomers/DeleteProductsToCustomers/{id}")]
        public void DeleteProductsToCustomers(int id)
        {
            Bll.ProductsToCustomersBll.DeleteProductsToCustomers(id);
        }
    }
}
