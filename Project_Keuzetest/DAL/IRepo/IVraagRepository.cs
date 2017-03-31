using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMAIN;

namespace DAL.Repo
{
    public interface IVraagRepository
    {
        IEnumerable<KeuzeVraag> readVraag(int niveau, string criteria);
        IEnumerable<AntwoordOptie> readAntwoordOpties(KeuzeVraag keuzevraag);
        IEnumerable<Resultaat> readResultaten(AntwoordOptie antwoordoptie);
        IEnumerable<PersonaVraag> readPersonaVragen();

        void useUnitOfWork(UnitOfWork uow);
    }
}
