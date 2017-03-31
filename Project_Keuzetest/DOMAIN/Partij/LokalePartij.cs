using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN.Partij
{
    class LokalePartij : Partij
    {
        public String Gemeente { get; set; }
        public Boolean Geactiveerd { get; set; }
        public double ProcentIngevuld { get; set; }
        public Partij NationalePartij { get; set; }
    }
}
