using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMAIN;

namespace BL
{
    public interface IVraagManager
    {
        KeuzeVraag getKeuzeVraag(int niveau, string criteria);
    }
}
