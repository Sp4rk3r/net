using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class EindResultaat
    {
        public int sessionId { get; set; }
        public string thema { get; set; }
        public string getoondeVraag { get; set; }
        public string gekozenAntwoordOptie { get; set; }
        public string verkregenResultaat { get; set; }
    }
}
