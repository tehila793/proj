using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
   public class CustomersBll
    {
        public static List<Dto.CustomersDto> GetAllCustomers()
        {
            return Dto.convert.CustomersConvert.ConvertDalEntityToDto(
                   Dal.CustomersDal.GetAllCustomers());

        }

        public static Dto.CustomersDto GetCustomerById(string id)
        {
            return Dto.convert.CustomersConvert.ConvertDalEntityToDto(Dal.CustomersDal.GetCustomerById(id));

        }

        public static void PostCustomer(Dto.CustomersDto cust)
        {
            Dal.CustomersDal.PostCustomer(Dto.convert.CustomersConvert.ConvertDalDtoToEntity(cust));
        }

        public static void PutCustomer(Dto.CustomersDto cust)
        {
            Dal.CustomersDal.PutCustomer(Dto.convert.CustomersConvert.ConvertDalDtoToEntity(cust));

        }

        public static void DeleteCustomer(string id)
        {
            Dal.CustomersDal.DeleteCustomer(id);
        }

    }
}
