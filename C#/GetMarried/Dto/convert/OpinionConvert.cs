using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.convert
{
   public class OpinionConvert
    {
        public static List<OpinionDto> ConvertDalEntityToDto(List<Dal.Opinion> opinion)
        {
            if (opinion == null)
                return null;
            List<OpinionDto> OpinionDtos = opinion.Select(a => ConvertDalEntityToDto(a)).ToList();
            return OpinionDtos;

        }


        public static OpinionDto ConvertDalEntityToDto(Dal.Opinion opinion)
        {
            if (opinion is null)
                return null;
            OpinionDto opinionDto = new OpinionDto()
            {
                id = opinion.id,
                opinion1=opinion.opinion1,
                rating=opinion.rating,
                idCategory = opinion.idCategory,
  

            };
            return opinionDto;

        }


        public static Dal.Opinion ConvertDalDtoToEntity(OpinionDto opinionDto)
        {
            try
            {
                Dal.Opinion opinion = new Dal.Opinion()
                {
                    id = opinionDto.id,
                    opinion1 = opinionDto.opinion1,
                    rating = opinionDto.rating,
                    idCategory = opinionDto.idCategory,
                };
                return opinion;

            }
            catch (Exception e)
            {
                return null;
            }
        }

    }
}
