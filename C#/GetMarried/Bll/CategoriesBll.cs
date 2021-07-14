using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class CategoriesBll
    {
        public static List<Dto.CategoriesDto> GetAllCategories()
        {
            return Dto.convert.CategoriesConvert.ConvertDalEntityToDto(
                   Dal.CategoriesDal.GetAllCategories());

        }

        public static Dto.CategoriesDto GetCategoryById(int id)
        {
            return Dto.convert.CategoriesConvert.ConvertDalEntityToDto(Dal.CategoriesDal.GetIDCategories(id));

        }

        public static void PostCategories(Dto.CategoriesDto categories)
        {
            //Dto.convert.CategoriesConvert.ConvertDalDtoToEntity(categories);
            Dal.CategoriesDal.PostCategory(Dto.convert.CategoriesConvert.ConvertDalDtoToEntity(categories));
        }

        public static void PutCategories(Dto.CategoriesDto categories)
        {
            Dal.CategoriesDal.PutCategory(Dto.convert.CategoriesConvert.ConvertDalDtoToEntity(categories));
            
        }

        public static void DeleteCategory(int id)
        {
            Dal.CategoriesDal.DeleteCategory(id);/*(Dto.convert.CategoriesConvert.ConvertDalDtoToEntity(Dal.CategoriesDal.DeleteCategory(id)*/ 
            //Dto.convert.CategoriesConvert.ConvertDalDtoToEntity(Dal.CategoriesDal.DeleteCategory(id));
        }
    }

}
