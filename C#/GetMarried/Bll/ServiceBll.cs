using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
   public class ServiceBll
    {
        public static List<Dto.ServiceDto> GetAllServices()
        {
            return Dto.convert.ServiceConvert.ConvertDalEntityToDto(
                   Dal.ServiceDal.GetAllServices());

        }

        public static Dto.ServiceDto GetServiceById(int id)
        {
            return Dto.convert.ServiceConvert.ConvertDalEntityToDto(Dal.ServiceDal.GetServiceById(id));

        }

        public static void PostService(Dto.ServiceDto Service)
        {
            Dal.ServiceDal.PostService(Dto.convert.ServiceConvert.ConvertDalDtoToEntity(Service));
        }

        public static void PutService(Dto.ServiceDto Service)
        {
            Dal.ServiceDal.PutService(Dto.convert.ServiceConvert.ConvertDalDtoToEntity(Service));

        }

        public static void DeleteService(int id)
        {
            Dal.ServiceDal.DeleteService(id);
        }

    }
}
