using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class AreaBll
    {
        public static List<Dto.AreaDto> GetAllArea()
        {
            return Dto.convert.AreaConvert.ConvertDalEntityToDto(
                   Dal.AreaDal.GetAllArea());

        }

        public static Dto.AreaDto GetAreaById(int id)
        {
            return Dto.convert.AreaConvert.ConvertDalEntityToDto(Dal.AreaDal.GetAreaByID(id));

        }

        public static void PostArea(Dto.AreaDto area)
        {
            //Dto.convert.CategoriesConvert.ConvertDalDtoToEntity(categories);
            Dal.AreaDal.PostArea(Dto.convert.AreaConvert.ConvertDalDtoToEntity(area));
        }

        public static void PutArea(Dto.AreaDto area)
        {
            Dal.AreaDal.PutArea(Dto.convert.AreaConvert.ConvertDalDtoToEntity(area));

        }

        public static void DeleteArea(int id)
        {
            Dal.AreaDal.DeleteArea(id);/*(Dto.convert.CategoriesConvert.ConvertDalDtoToEntity(Dal.CategoriesDal.DeleteCategory(id)*/
            //Dto.convert.CategoriesConvert.ConvertDalDtoToEntity(Dal.CategoriesDal.DeleteCategory(id));
        }
    }
}
