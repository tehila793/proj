using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class OpinionBll
    {
        public static List<Dto.OpinionDto> GetAllOpinion()
        {
            return Dto.convert.OpinionConvert.ConvertDalEntityToDto(
                   Dal.OpinionDal.GetAllOpinion());

        }

        public static Dto.OpinionDto GetOpinionById(int id)
        {
            return Dto.convert.OpinionConvert.ConvertDalEntityToDto(Dal.OpinionDal.GetOpinionById(id));

        }

        public static void PostOpinion(Dto.OpinionDto opinion)
        {
            Dal.OpinionDal.PostOpinion(Dto.convert.OpinionConvert.ConvertDalDtoToEntity(opinion));
        }

        public static void PutOpinion(Dto.OpinionDto opinion)
        {
            Dal.OpinionDal.PutOpinion(Dto.convert.OpinionConvert.ConvertDalDtoToEntity(opinion));

        }

        public static void DeleteOpinion(int id)
        {
            Dal.OpinionDal.DeleteOpinion(id);
        }

    }
}
