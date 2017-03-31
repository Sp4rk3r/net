using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class PartijAntwoord
    {
        public LokalePartij LokalePartij { get; set; }
        public Thema Thema { get; set; }
        public String AntwoordTekst { get; set; }
        public String StandaardAntwoordTekst { get; set; }
    }
}
