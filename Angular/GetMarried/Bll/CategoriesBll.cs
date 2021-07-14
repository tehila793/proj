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


        public static void PostCategories(Dal.Categories categories)
        {
            Dal.CategoriesDal.PostCategory(categories);

        }
    }

}
