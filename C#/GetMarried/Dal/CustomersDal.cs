using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class CustomersDal
    {
        public static List<Dal.Customers> GetAllCustomers()
        {
            List<Dal.Customers> list = new List<Customers>();
            try
            {
                list = ManangementEntitiesSingleton.Instance.Customers.ToList();
            }
            catch (Exception e)
            {
                return null;
            }

            return list;
        }


        public static Dal.Customers GetCustomerById(string id)
        {
            try
            {
                return ManangementEntitiesSingleton.Instance.Customers.Find(id);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static void PostCustomer(Dal.Customers customers)
        {
            try
            {
                ManangementEntitiesSingleton.Instance.Customers.Add(customers);
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
                ;
            }
        }


        public static void PutCustomer(Dal.Customers customer)
        {
            Customers cust = ManangementEntitiesSingleton.Instance.Customers.Where(x => x.id == customer.id).FirstOrDefault();

            try
            {

                //cust.id = customer.id;
                cust.name = customer.name;
                cust.phone = customer.phone;
                cust.mail = customer.mail;
                cust.password = customer.password;
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void DeleteCustomer(string id)
        {
            try
            {
                //
                Customers cust = ManangementEntitiesSingleton.Instance.Customers.Where(x => x.id == id).FirstOrDefault();
                ManangementEntitiesSingleton.Instance.Customers.Remove(cust);
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
                ;
            }
        }
    }
}
