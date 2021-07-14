using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class AddressDal
    {
        public static List<Dal.Address> GetAllAddress()
        {
            List<Dal.Address> list = new List<Address>();
            try
            {
                list = ManangementEntitiesSingleton.Instance.Address.ToList();
            }
            catch (Exception e)
            {
                return null;
            }

            return list;
        }


        public static Dal.Address GetAddressById(int id)
        {
            try
            {
                return ManangementEntitiesSingleton.Instance.Address.Find(id);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static void PostAddress(Dal.Address address)
        {
            try
            {
                ManangementEntitiesSingleton.Instance.Address.Add(address);
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
                ;
            }
        }


        public static void PutAddress(Dal.Address address)
        {
            Address addres = ManangementEntitiesSingleton.Instance.Address.Where(x => x.id == address.id).FirstOrDefault();

            try
            {
                addres.idCategory = address.idCategory;
                addres.idArea = address.idArea;
                addres.city = address.city;
                addres.street = address.street;
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void DeleteAddress(int id)
        {
            try
            {
                Address adres = ManangementEntitiesSingleton.Instance.Address.Where(x => x.id == id).FirstOrDefault();
                ManangementEntitiesSingleton.Instance.Address.Remove(adres);
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
                ;
            }
        }

    }
}
