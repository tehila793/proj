using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class CategoriesDal
    {
        public static List<Dal.Categories> GetAllCategories()
        {
            try
            {
                return ManangementEntitiesSingleton.Instance.Categories.ToList();
            }
            catch
            {
                return null;
            }
        }


        public static void PostCategory(Dal.Categories categories)
        {
            try
            {
                ManangementEntitiesSingleton.Instance.Categories.Add(categories);
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch
            {
                ;
            }
        }

    }
}
