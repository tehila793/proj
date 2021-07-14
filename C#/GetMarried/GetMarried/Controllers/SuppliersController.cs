using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace GetMarried.Controllers
{
    public class SuppliersController : ApiController
    {
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        // GET: api/Suppliers
        [HttpGet]
        [Route("api/Suppliers/GetAllSuppliers")]
        public List<Dto.SuppliersDto> GetAllSuppliers()
        {
            return Bll.SuppliersBll.GetAllSuppliers();
        }

        [HttpGet]
        [Route("api/Suppliers/GetSupplierById/{id}")]
        public Dto.SuppliersDto GetSupplierById(int id)
        {
            return Bll.SuppliersBll.GetSupplierById(id);
        }


        // POST: api/Suppliers
        //add
        [HttpPost]
        [Route("api/Suppliers/PostSuppliers")]
        public void PostSuppliers(Dto.SuppliersDto supplier)
        {
            Bll.SuppliersBll.PostSupplier(supplier);
        }


        [HttpPut]
        [Route("api/Suppliers/PutSupplier")]
        public void PutSupplier(Dto.SuppliersDto supplier)
        {
            Bll.SuppliersBll.PutSupplier(supplier);
        }


        // DELETE: api/Suppliers/5
        [HttpDelete]
        [Route("api/Suppliers/DeleteSupplier/{id}")]
        public void DeleteSupplier(int id)
        {
            Bll.SuppliersBll.DeleteSupplier(id);
        }
    }
}
