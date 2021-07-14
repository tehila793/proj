using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class HallsDal
    {

        public static List<Dal.Halls> GetAllHalls()
        {
            List<Dal.Halls> list = new List<Halls>();
            try
            {
                list = ManangementEntitiesSingleton.Instance.Halls.ToList();
            }
            catch (Exception e)
            {
                return null;
            }

            return list;
        }


        public static Dal.Halls GetHallById(int id)
        {
            try
            {
                return ManangementEntitiesSingleton.Instance.Halls.Find(id);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static void PostHall(Dal.Halls halls)
        {
            try
            {
                ManangementEntitiesSingleton.Instance.Halls.Add(halls);
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
                ;
            }
        }


        public static void PutHall(Dal.Halls hall)
        {
            Halls hal = ManangementEntitiesSingleton.Instance.Halls.Where(x => x.id == hall.id).FirstOrDefault();

            try
            {
                //hal.id = hall.id;
                hal.name = hall.name;
                hal.phone = hall.phone;
                hal.fax = hall.phone;
                hal.invited = hall.invited;
                hal.kashrut = hall.kashrut;
                hal.price = hall.price;
                hal.idtype = hall.idtype;
                hal.idCategory = hall.idCategory;
                hal.idAddress = hall.idAddress;
                hal.idOpinion = hall.idOpinion;
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void DeleteHall(int id)
        {
            try
            {
                Halls hall = ManangementEntitiesSingleton.Instance.Halls.Where(x => x.id == id).FirstOrDefault();
                ManangementEntitiesSingleton.Instance.Halls.Remove(hall);
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
                ;
            }
        }
    }
}
