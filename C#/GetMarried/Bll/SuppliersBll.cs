using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
   public class SuppliersBll
    {
        public static List<Dto.SuppliersDto> GetAllSuppliers()
        {
            return Dto.convert.SuppliersConvert.ConvertDalEntityToDto(
                   Dal.SuppliersDal.GetAllSuppliers());

        }

        public static Dto.SuppliersDto GetSupplierById(int id)
        {
            return Dto.convert.SuppliersConvert.ConvertDalEntityToDto(Dal.SuppliersDal.GetSupplierById(id));

        }

        public static void PostSupplier(Dto.SuppliersDto Suppliers)
        {
            Dal.SuppliersDal.PostSupplier(Dto.convert.SuppliersConvert.ConvertDalDtoToEntity(Suppliers));
        }

        public static void PutSupplier(Dto.SuppliersDto Suppliers)
        {
            Dal.SuppliersDal.PutSupplier(Dto.convert.SuppliersConvert.ConvertDalDtoToEntity(Suppliers));

        }

        public static void DeleteSupplier(int id)
        {
            Dal.SuppliersDal.DeleteSupplier(id);
        }

    }
}
