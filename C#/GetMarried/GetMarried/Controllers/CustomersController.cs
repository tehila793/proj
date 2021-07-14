using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace GetMarried.Controllers
{
    public class CustomersController : ApiController
    {
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        // GET: api/Customers
        [HttpGet]
        [Route("api/Area/GetAllCustomers")]
        public List<Dto.CustomersDto> GetAllCustomers()
        {
            return Bll.CustomersBll.GetAllCustomers();
        }

        // GET: api/Customers/5
        [HttpGet]
        [Route("api/Customers/GetCustomerById/{id}")]
        public Dto.CustomersDto GetCustomerById(string id)
        {
            return Bll.CustomersBll.GetCustomerById(id);
        }

        // POST: api/Customers
        [HttpPost]
        [Route("api/Customers/PostCustomer")]
        public void PostCustomer(Dto.CustomersDto customers)
        {
            Bll.CustomersBll.PostCustomer(customers);
        }

        // PUT: api/Customers/5
        [HttpPut]
        [Route("api/Customers/PutCustomer")]
        public void PutCustomer(Dto.CustomersDto customers)
        {
            Bll.CustomersBll.PutCustomer(customers);
        }

        // DELETE: api/Customers/5
        [HttpDelete]
        [Route("api/Customers/DeleteCustomer/{id}")]
        public void DeleteCustomer(string id)
        {
            Bll.CustomersBll.DeleteCustomer(id);
        }
    }
}
