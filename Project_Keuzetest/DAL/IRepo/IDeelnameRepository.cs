using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMAIN;

namespace DAL.Repo
{
    public interface IDeelnameRepository
    {
        Deelname createEindResultaat(EindResultaat eindresultaat);
        Deelname createDeelname(Deelname deelname);
        List<EindResultaat> readEindResultaten(Deelname deelname);

        void useUnitOfWork(UnitOfWork uow);
    }
}
