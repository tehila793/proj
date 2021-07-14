using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class ServiceDal
    {
        public static List<Dal.Service> GetAllServices()
        {
            List<Dal.Service> list = new List<Service>();
            try
            {
                list = ManangementEntitiesSingleton.Instance.Service.ToList();
            }
            catch (Exception e)
            {
                return null;
            }

            return list;
        }


        public static Dal.Service GetServiceById(int id)
        {
            try
            {
                return ManangementEntitiesSingleton.Instance.Service.Find(id);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static void PostService(Dal.Service serv)
        {
            try
            {
                ManangementEntitiesSingleton.Instance.Service.Add(serv);
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
                ;
            }
        }


        public static void PutService(Dal.Service service)
        {
            Service serv = ManangementEntitiesSingleton.Instance.Service.Where(x => x.id == service.id).FirstOrDefault();

            try
            {
                //serv.id = service.id;
                serv.type = service.type;
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void DeleteService(int id)
        {
            try
            {
                Service service = ManangementEntitiesSingleton.Instance.Service.Where(x => x.id == id).FirstOrDefault();
                ManangementEntitiesSingleton.Instance.Service.Remove(service);
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
                ;
            }
        }

    }
}
