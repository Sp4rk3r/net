using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.EF;

namespace DAL
{
    public class UnitOfWork
    {
        private KeuzetestDbContext ctx;

        internal KeuzetestDbContext context
        {
            get
            {
                if (ctx == null) ctx = new KeuzetestDbContext(true);
                return ctx;
            }
        }

        public void CommitChanges()
        {
            ctx.CommitChanges();
        }
    }
}
