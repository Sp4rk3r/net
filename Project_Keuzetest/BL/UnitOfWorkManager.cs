using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BL
{
    public class UnitOfWorkManager
    {
        private UnitOfWork uow;

        internal UnitOfWork UnitOfWork
        {
            get
            {
                if (uow == null) uow = new UnitOfWork();
                return uow;
            }
        }

        public void Save()
        {
            UnitOfWork.CommitChanges();
        }
    }
}
