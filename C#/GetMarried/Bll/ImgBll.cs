using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
   public class ImgBll
    {

        public static List<Dto.ImgDto> GetAllImg()
        {
            return Dto.convert.ImgConvert.ConvertDalEntityToDto(
                   Dal.ImgDal.GetAllImg());

        }

        public static Dto.ImgDto GetImgById(int id)
        {
            return Dto.convert.ImgConvert.ConvertDalEntityToDto(Dal.ImgDal.GetImgById(id));

        }

        public static void PostImg(Dto.ImgDto img)
        {
            Dal.ImgDal.PostImg(Dto.convert.ImgConvert.ConvertDalDtoToEntity(img));
        }

        public static void PutImg(Dto.ImgDto img)
        {
            Dal.ImgDal.PutImg(Dto.convert.ImgConvert.ConvertDalDtoToEntity(img));

        }

        public static void DeleteImg(int id)
        {
            Dal.ImgDal.DeleteImg(id);
        }

    }
}
