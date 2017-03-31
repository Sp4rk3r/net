﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMAIN;

namespace DAL.Repo
{
    public interface IAdminRepository
    {
        //ADMIN
        void createVraag(KeuzeVraag keuzevraag);
        void createAntwoordopties(KeuzeVraag keuzevraag, IEnumerable<AntwoordOptie> antwoordopties);
        void createResultaten(AntwoordOptie antwoordoptie, IEnumerable<Resultaat> resultaten);

        //SUPERADMIN
        void createAdmin(string mail);
    }
}
