using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Resultaat
    {
        public string resultaatTekst { get; set; }
        public double Kans { get; set; }
        public string Status { get; set; }
        public virtual AntwoordOptie antwoordoptie { get; set; }
    }
}
