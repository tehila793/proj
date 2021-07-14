using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
   public class CategoriesDto
    {
        public int id { get; set; }
        public string name { get; set; }

        public CategoriesDto()
        {

        }
       
        public CategoriesDto(CategoriesDto c)
        {
            //this.id = c.id;
            
          this.name = c.name;
        }
    }
}
