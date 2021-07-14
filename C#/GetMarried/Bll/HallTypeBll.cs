using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
	public class HallTypeBll
	{
        public static List<Dto.HallTypeDto> GetAllHallType()
        {
            return Dto.convert.HallTypeConvert.ConvertDalEntityToDto(
                   Dal.HallTypeDal.GetAllHallType());

        }

        public static Dto.HallTypeDto GetHallTypeById(int id)
        {
            return Dto.convert.HallTypeConvert.ConvertDalEntityToDto(Dal.HallTypeDal.GetHallTypeById(id));

        }

        public static void PostHallType(Dto.HallTypeDto hall)
        {
            Dal.HallTypeDal.PostHallType(Dto.convert.HallTypeConvert.ConvertDalDtoToEntity(hall));
        }

        public static void PutHallType(Dto.HallTypeDto hall)
        {
            Dal.HallTypeDal.PutHallType(Dto.convert.HallTypeConvert.ConvertDalDtoToEntity(hall));

        }

        public static void DeleteHallType(int id)
        {
            Dal.HallTypeDal.DeleteHallType(id);
        }

    }
}
