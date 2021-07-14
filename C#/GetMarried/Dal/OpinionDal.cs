using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class OpinionDal
    {
        public static List<Dal.Opinion> GetAllOpinion()
        {
            List<Dal.Opinion> list = new List<Opinion>();
            try
            {
                list = ManangementEntitiesSingleton.Instance.Opinion.ToList();
            }
            catch (Exception e)
            {
                return null;
            }

            return list;
        }


        public static Dal.Opinion GetOpinionById(int id)
        {
            try
            {
                return ManangementEntitiesSingleton.Instance.Opinion.Find(id);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static void PostOpinion(Dal.Opinion opinion)
        {
            try
            {
                ManangementEntitiesSingleton.Instance.Opinion.Add(opinion);
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
                ;
            }
        }


        public static void PutOpinion(Dal.Opinion opinion)
        {
            Opinion opin = ManangementEntitiesSingleton.Instance.Opinion.Where(x => x.id == opinion.id).FirstOrDefault();

            try
            {
                //opin.id = opinion.id;
                opin.opinion1 = opinion.opinion1;
                opin.rating = opinion.rating;
                opin.idCategory = opinion.idCategory;
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void DeleteOpinion(int id)
        {
            try
            {
                Opinion opinion = ManangementEntitiesSingleton.Instance.Opinion.Where(x => x.id == id).FirstOrDefault();
                ManangementEntitiesSingleton.Instance.Opinion.Remove(opinion);
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
                ;
            }
        }

    }
}
