using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
   public class ProductsToCustomersDal
    {
        public static List<Dal.ProductsToCustomers> GetAllProductsToCustomers()
        {
            List<Dal.ProductsToCustomers> list = new List<ProductsToCustomers>();
            try
            {
                list = ManangementEntitiesSingleton.Instance.ProductsToCustomers.ToList();
            }
            catch (Exception e)
            {
                return null;
            }

            return list;
        }


        public static Dal.ProductsToCustomers GetProductsToCustomersById(int id)
        {
            try
            {
                return ManangementEntitiesSingleton.Instance.ProductsToCustomers.Find(id);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static void PostProductsToCustomers(Dal.ProductsToCustomers ProdToCustomers)
        {
            try
            {
                ManangementEntitiesSingleton.Instance.ProductsToCustomers.Add(ProdToCustomers);
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
                ;
            }
        }


        public static void PutProductsToCustomers(Dal.ProductsToCustomers ProdToCustomers)
        {
            ProductsToCustomers ProductsToCustomerses = ManangementEntitiesSingleton.Instance.ProductsToCustomers.Where(x => x.id == ProdToCustomers.id).FirstOrDefault();

            try
            {
                //ProductsToCustomerses.id = ProdToCustomers.id;
                ProductsToCustomerses.idSuppliers = ProdToCustomers.idSuppliers;
                ProductsToCustomerses.idCustomer = ProdToCustomers.idCustomer;
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void DeleteProductsToCustomers(int id)
        {
            try
            {
                ProductsToCustomers ProdToCustomers = ManangementEntitiesSingleton.Instance.ProductsToCustomers.Where(x => x.id == id).FirstOrDefault();
                ManangementEntitiesSingleton.Instance.ProductsToCustomers.Remove(ProdToCustomers);
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
                ;
            }
        }
    }
}
