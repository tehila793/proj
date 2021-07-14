using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class AddressDto
    {

        public int id { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public int idCategory { get; set; }
        public int idArea { get; set; }
      
        
    }
}
