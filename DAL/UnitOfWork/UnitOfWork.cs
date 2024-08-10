using DAL.Database;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UnitOfWork
{
    public class UnitOfWork : IDisposable
    {
        private JOEntities _JOEntities = new JOEntities();
        //private GenericRepository<tbl_accounts_serialInquiry> _Loginusers;
        //public GenericRepository<tbl_accounts_serialInquiry> LoginUsers
        //{
        //    get
        //    {

        //        if (this._Loginusers == null)
        //        {
        //            this._Loginusers = new GenericRepository<tbl_accounts_serialInquiry>(_Context);
        //        }
        //        return _Loginusers;
        //    }
        //}

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _JOEntities.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public DbRawSqlQuery<T> SQLQuery<T>(string sql, params object[] parameters)
        {
            return _JOEntities.Database.SqlQuery<T>(sql, parameters);
        }
        public void Save()
        {
            _JOEntities.SaveChanges();
        }
    }
}
