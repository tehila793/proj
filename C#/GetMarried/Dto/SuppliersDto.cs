using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
   public class SuppliersDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public Nullable<int> price { get; set; }
        public Nullable<System.DateTime> activity_time { get; set; }
        public int idCategory { get; set; }
        public int idAddress { get; set; }
        public int idservice { get; set; }
    }
}
