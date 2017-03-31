using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMAIN;
using System.Data.Entity;

namespace DAL.EF
{
    internal class KeuzetestDbContext : DbContext
    {
        private readonly bool delaySave;

        public KeuzetestDbContext(bool UnitOfWorkPresent = false) : base("KeuzetestDb"){
            delaySave = UnitOfWorkPresent;
        }

        public override int SaveChanges()
        {
            if (delaySave)
            {
                return -1;
            }
            return base.SaveChanges();
        }

        internal int CommitChanges()
        {
            if (delaySave)
            {
                return base.SaveChanges();
            }
            throw new InvalidOperationException("No UnitOfWork Present, use SaveChanges instead.");
        }
    }
}
