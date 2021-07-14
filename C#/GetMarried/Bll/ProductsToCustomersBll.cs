using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
  public  class ProductsToCustomersBll
    {

        public static List<Dto.ProductsToCustomersDto> GetAllProductsToCustomers()
        {
            return Dto.convert.ProductsToCustomersConvert.ConvertDalEntityToDto(
                   Dal.ProductsToCustomersDal.GetAllProductsToCustomers());

        }

        public static Dto.ProductsToCustomersDto GetProductsToCustomersById(int id)
        {
            return Dto.convert.ProductsToCustomersConvert.ConvertDalEntityToDto(Dal.ProductsToCustomersDal.GetProductsToCustomersById(id));

        }

        public static void PostProductsToCustomers(Dto.ProductsToCustomersDto ProdToCustomers)
        {
            Dal.ProductsToCustomersDal.PostProductsToCustomers(Dto.convert.ProductsToCustomersConvert.ConvertDalDtoToEntity(ProdToCustomers));
        }

        public static void PutProductsToCustomers(Dto.ProductsToCustomersDto ProdToCustomers)
        {
            Dal.ProductsToCustomersDal.PutProductsToCustomers(Dto.convert.ProductsToCustomersConvert.ConvertDalDtoToEntity(ProdToCustomers));

        }

        public static void DeleteProductsToCustomers(int id)
        {
            Dal.ProductsToCustomersDal.DeleteProductsToCustomers(id);
        }


    }
}
