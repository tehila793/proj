using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.convert
{
    public class HallsConvert
    {
        public static List<HallsDto> ConvertDalEntityToDto(List<Dal.Halls> halls)
        {
            if (halls == null)
                return null;
            List<HallsDto> HallsDto = halls.Select(a => ConvertDalEntityToDto(a)).ToList();
            return HallsDto;

        }

        public static HallsDto ConvertDalEntityToDto(Dal.Halls halls)
        {
            if (halls is null)
                return null;
            HallsDto hallsDto = new HallsDto()
            {
                id = halls.id,
                name = halls.name,
                phone = halls.phone,
                fax = halls.phone,
                invited = halls.invited,
                kashrut = halls.kashrut,
                price = halls.price,
                idtype = halls.idtype,
                idCategory = halls.idCategory,
                idAddress = halls.idAddress,
                idOpinion = halls.idOpinion,
            };

            return hallsDto;

        }


        public static Dal.Halls ConvertDalDtoToEntity(HallsDto hallsDto )
        {
            try
            {
                Dal.Halls halls = new Dal.Halls()
                {

                    id = hallsDto.id,
                    name = hallsDto.name,
                    phone = hallsDto.phone,
                    fax = hallsDto.phone,
                    invited = hallsDto.invited,
                    kashrut = hallsDto.kashrut,
                    price = hallsDto.price,
                    idtype = hallsDto.idtype,
                    idCategory = hallsDto.idCategory,
                    idAddress = hallsDto.idAddress,
                    idOpinion = hallsDto.idOpinion,
                };
                return halls;

            }
            catch (Exception e)
            {
                return null;
            }
        }

    }
}
