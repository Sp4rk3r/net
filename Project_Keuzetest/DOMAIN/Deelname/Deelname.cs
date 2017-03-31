using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class Deelname
    {
        public int sessionId { get; set; }
        public int Score { get; set; }
        public virtual ICollection<EindResultaat> EindResultaten { get; set; }
        public ICollection<Resultaat> Resultaten { get; set; }
        public String Persona { get; set; }
    }
}
