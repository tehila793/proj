using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dto
{
    public class OpinionDto
    {
        public int id { get; set; }
        public string opinion1 { get; set; }
        public Nullable<int> rating { get; set; }
        public int idCategory { get; set; }
    }
}
