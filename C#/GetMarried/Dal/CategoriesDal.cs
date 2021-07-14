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
            catch (Exception e)
            {
                return null;
            }
        }

        public static Dal.Categories GetIDCategories(int id)
        {
            try
            {
                return ManangementEntitiesSingleton.Instance.Categories.Find(id);
            }
            catch (Exception e)
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
            catch (Exception e)
            {
                ;
            }
        }


        public static void PutCategory(Dal.Categories categories)
        {
            Categories category = ManangementEntitiesSingleton.Instance.Categories.Where(x => x.id == categories.id).FirstOrDefault();

            try
            {
                category.name = categories.name;
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void DeleteCategory(int id/*Dal.Categories categories*/)
        {
            try
            {

                //var categories = ManangementEntitiesSingleton.Instance.Categories.Where(s => s.id == id).FirstOrDefault();
                Categories categories = ManangementEntitiesSingleton.Instance.Categories.Where(x => x.id == id).FirstOrDefault();
                ManangementEntitiesSingleton.Instance.Categories.Remove(categories);
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
                ;
            }
        }
    }
}
