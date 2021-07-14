using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
   public class AddressBll
    {

        public static List<Dto.AddressDto> GetAllAddress()
        {
            return Dto.convert.AddressConvert.ConvertDalEntityToDto(
                   Dal.AddressDal.GetAllAddress());

        }

        public static Dto.AddressDto GetAddressById(int id)
        {
            return Dto.convert.AddressConvert.ConvertDalEntityToDto(Dal.AddressDal.GetAddressById(id));

        }

        public static void PostAddress(Dto.AddressDto address)
        {
            //Dto.convert.CategoriesConvert.ConvertDalDtoToEntity(categories);
            Dal.AddressDal.PostAddress(Dto.convert.AddressConvert.ConvertDalDtoToEntity(address));
        }

        public static void PutAddress(Dto.AddressDto address)
        {
            Dal.AddressDal.PutAddress(Dto.convert.AddressConvert.ConvertDalDtoToEntity(address));

        }

        public static void DeleteAddress(int id)
        {
            Dal.AddressDal.DeleteAddress(id);
        }
    }
}
