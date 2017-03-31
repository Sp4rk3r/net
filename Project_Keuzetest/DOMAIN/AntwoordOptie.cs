using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class AntwoordOptie
    {
        public string antwoordTekst { get; set; }
        public string Voordelen { get; set; }
        public string Nadelen { get; set; }
        public double? KansOpEinde { get; set; }
        public string TekstEinde { get; set; }
        public virtual ICollection<Resultaat> Resultaten { get; set; }
        public virtual KeuzeVraag vraag { get; set; }
    }
}
