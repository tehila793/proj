using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class HallsBll
    {
        public static List<Dto.HallsDto> GetAllHalls()
        {
            return Dto.convert.HallsConvert.ConvertDalEntityToDto(
                   Dal.HallsDal.GetAllHalls());

        }

        public static Dto.HallsDto GetHallById(int id)
        {
            return Dto.convert.HallsConvert.ConvertDalEntityToDto(Dal.HallsDal.GetHallById(id));

        }

        public static void PostHall(Dto.HallsDto hall)
        {
            Dal.HallsDal.PostHall(Dto.convert.HallsConvert.ConvertDalDtoToEntity(hall));
        }

        public static void PutHall(Dto.HallsDto hall)
        {
            Dal.HallsDal.PutHall(Dto.convert.HallsConvert.ConvertDalDtoToEntity(hall));

        }

        public static void DeleteHall(int id)
        {
            Dal.HallsDal.DeleteHall(id);
        }
    }
}
