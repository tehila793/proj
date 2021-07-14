using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class SuppliersDal
    {

        public static List<Dal.Suppliers> GetAllSuppliers()
        {
            List<Dal.Suppliers> list = new List<Suppliers>();
            try
            {
                list = ManangementEntitiesSingleton.Instance.Suppliers.ToList();
            }
            catch (Exception e)
            {
                return null;
            }

            return list;
        }


        public static Dal.Suppliers GetSupplierById(int id)
        {
            try
            {
                return ManangementEntitiesSingleton.Instance.Suppliers.Find(id);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static void PostSupplier(Dal.Suppliers supplier)
        {
            try
            {
                ManangementEntitiesSingleton.Instance.Suppliers.Add(supplier);
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
                ;
            }
        }


        public static void PutSupplier(Dal.Suppliers supplier)
        {
            Suppliers sup = ManangementEntitiesSingleton.Instance.Suppliers.Where(x => x.id == supplier.id).FirstOrDefault();

            try
            {
                // sup.id = supplier.id;
                sup.name = supplier.name;
                sup.phone = supplier.phone;
                sup.price = supplier.price;
                sup.activity_time = supplier.activity_time;
                sup.idCategory = supplier.idCategory;
                sup.idAddress = supplier.idAddress;
                sup.idservice = supplier.idservice;
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void DeleteSupplier(int id)
        {
            try
            {
                Suppliers supplier = ManangementEntitiesSingleton.Instance.Suppliers.Where(x => x.id == id).FirstOrDefault();
                ManangementEntitiesSingleton.Instance.Suppliers.Remove(supplier);
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
                ;
            }
        }
    }
}
