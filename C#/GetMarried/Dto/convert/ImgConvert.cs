using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto.convert
{
  public  class ImgConvert
    {

        public static List<ImgDto> ConvertDalEntityToDto(List<Dal.Img> img)
        {
            if (img == null)
                return null;
            List<ImgDto> ImgDto = img.Select(a => ConvertDalEntityToDto(a)).ToList();
            return ImgDto;

        }

        public static ImgDto ConvertDalEntityToDto(Dal.Img img)
        {
            if (img is null)
                return null;
            ImgDto imgDto = new ImgDto()
            {
                id = img.id,
                idCategory = img.idCategory,
                src = img.src,
            };
            return imgDto;
        }


        public static Dal.Img ConvertDalDtoToEntity(ImgDto imgDto)
        {
            try
            {
                Dal.Img img = new Dal.Img()
                {
                    id = imgDto.id,
                    idCategory = imgDto.idCategory,
                    src = imgDto.src,
                };
                return img;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
