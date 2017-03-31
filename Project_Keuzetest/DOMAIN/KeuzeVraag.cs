using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class KeuzeVraag : Vraag
    {
        public virtual Thema thema { get; set; }
        public string Criteria { get; set; }
    }
}
