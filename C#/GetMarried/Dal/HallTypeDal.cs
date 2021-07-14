using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
	public class HallTypeDal
	{
        public static List<Dal.HallType> GetAllHallType()
        {
            List<Dal.HallType> list = new List<HallType>();
            try
            {
                list = ManangementEntitiesSingleton.Instance.HallType.ToList();
            }
            catch (Exception e)
            {
                return null;
            }

            return list;
        }


        public static Dal.HallType GetHallTypeById(int id)
        {
            try
            {
                return ManangementEntitiesSingleton.Instance.HallType.Find(id);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static void PostHallType(Dal.HallType HallType)
        {
            try
            {
                ManangementEntitiesSingleton.Instance.HallType.Add(HallType);
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
                ;
            }
        }


        public static void PutHallType(Dal.HallType HallType)
        {
            HallType hall = ManangementEntitiesSingleton.Instance.HallType.Where(x => x.id == HallType.id).FirstOrDefault();

            try
            {

                //cust.id = HallType.id;
                hall.type = HallType.type;
                
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void DeleteHallType(int id)
        {
            try
            {
                //
                HallType hall = ManangementEntitiesSingleton.Instance.HallType.Where(x => x.id == id).FirstOrDefault();
                ManangementEntitiesSingleton.Instance.HallType.Remove(hall);
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
                ;
            }
        }
    }
}
