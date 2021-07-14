using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class AreaDal
    {
        public static List<Dal.Area> GetAllArea()
        {
            try
            {
                return ManangementEntitiesSingleton.Instance.Area.ToList();
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static Dal.Area GetAreaByID(int id)
        {
            try
            {
                return ManangementEntitiesSingleton.Instance.Area.Find(id);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static void PostArea(Dal.Area area)
        {
            try
            {
                ManangementEntitiesSingleton.Instance.Area.Add(area);
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
                ;
            }
        }


        public static void PutArea(Dal.Area area)
        {
            Area are = ManangementEntitiesSingleton.Instance.Area.Where(x => x.id == area.id).FirstOrDefault();

            try
            {
                are.area1 = area.area1;
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void DeleteArea(int id/*Dal.Categories categories*/)
        {
            try
            {

                //var categories = ManangementEntitiesSingleton.Instance.Categories.Where(s => s.id == id).FirstOrDefault();
                Area area = ManangementEntitiesSingleton.Instance.Area.Where(x => x.id == id).FirstOrDefault();
                ManangementEntitiesSingleton.Instance.Area.Remove(area);
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
                ;
            }
        }
    }
}
