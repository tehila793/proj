using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.convert
{
   public class SuppliersConvert

    {
        public static List<SuppliersDto> ConvertDalEntityToDto(List<Dal.Suppliers> suppliers)
        {
            if (suppliers == null)
                return null;
            List<SuppliersDto> SuppliersDto = suppliers.Select(a => ConvertDalEntityToDto(a)).ToList();
            return SuppliersDto;

        }

        public static SuppliersDto ConvertDalEntityToDto(Dal.Suppliers supplier)
        {
            if (supplier is null)
                return null;
            SuppliersDto SuppliersDto = new SuppliersDto()
            {
                id = supplier.id,
                name = supplier.name,
                phone = supplier.phone,
                price = supplier.price,
                activity_time = supplier.activity_time,
                idCategory = supplier.idCategory,
                idAddress = supplier.idAddress,
                idservice = supplier.idservice,
            };

            return SuppliersDto;

        }


        public static Dal.Suppliers ConvertDalDtoToEntity(SuppliersDto SuppliersDto)
        {
            try
            {
                Dal.Suppliers Suppliers = new Dal.Suppliers()
                {

                    id = SuppliersDto.id,
                    name = SuppliersDto.name,
                    phone = SuppliersDto.phone,
                    price = SuppliersDto.price,
                    activity_time = SuppliersDto.activity_time,
                    idCategory = SuppliersDto.idCategory,
                    idAddress = SuppliersDto.idAddress,
                    idservice = SuppliersDto.idservice,
                };
                return Suppliers;

            }
            catch (Exception e)
            {
                return null;
            }
        }

    }
}
