using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.convert
{
    public class CustomersConvert
    {
        public static List<CustomersDto> ConvertDalEntityToDto(List<Dal.Customers> cust)
        {
            if (cust == null)
                return null;
            List<CustomersDto> customerDto = cust.Select(a => ConvertDalEntityToDto(a)).ToList();
            return customerDto;

        }

        public static CustomersDto ConvertDalEntityToDto(Dal.Customers customers)
        {
            if (customers is null)
                return null;
            CustomersDto customersDto = new CustomersDto()
            {
                id = customers.id,
                name = customers.name,
                phone = customers.phone,
                mail = customers.mail,
                password = customers.password,
            };

            return customersDto;

        }


        public static Dal.Customers ConvertDalDtoToEntity(CustomersDto customersDto)
        {
            try
            {
                Dal.Customers cust = new Dal.Customers()
                {
                    id = customersDto.id,
                    name = customersDto.name,
                    phone = customersDto.phone,
                    mail = customersDto.mail,
                    password = customersDto.password,
                };
                return cust;

            }
            catch (Exception e)
            {
                return null;
            }
        }

    }
}
