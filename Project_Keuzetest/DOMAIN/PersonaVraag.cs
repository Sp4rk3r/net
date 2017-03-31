using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOMAIN
{
    public class PersonaVraag : Vraag
    {
        public string personavraag { get; set; }
        public List<String> opties { get; set; }
    }
}
