using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
   public class ImgDal
    {

        public static List<Dal.Img> GetAllImg()
        {
            List<Dal.Img> list = new List<Img>();
            try
            {
                list = ManangementEntitiesSingleton.Instance.Img.ToList();
            }
            catch (Exception e)
            {
                return null;
            }

            return list;
        }


        public static Dal.Img GetImgById(int id)
        {
            try
            {
                return ManangementEntitiesSingleton.Instance.Img.Find(id);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static void PostImg(Dal.Img img)
        {
            try
            {
                ManangementEntitiesSingleton.Instance.Img.Add(img);
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
                ;
            }
        }


        public static void PutImg(Dal.Img img)
        {
            Img imges = ManangementEntitiesSingleton.Instance.Img.Where(x => x.id == img.id).FirstOrDefault();

            try
            {
                //imges.id = img.id;
                imges.src = img.src;
                imges.idCategory = img.idCategory;
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void DeleteImg(int id)
        {
            try
            {
                Img img = ManangementEntitiesSingleton.Instance.Img.Where(x => x.id == id).FirstOrDefault();
                ManangementEntitiesSingleton.Instance.Img.Remove(img);
                ManangementEntitiesSingleton.Instance.SaveChanges();
            }
            catch (Exception e)
            {
                ;
            }
        }

    }
}
