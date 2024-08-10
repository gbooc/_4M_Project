using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {

        //GenericRepository<tbl_accounts_serialInquiry> _Tbl_accounts_serialInquiry -- name of table
        DbRawSqlQuery<T> SQLQuery<T>(string sql, params object[] parameters);
        void Save();
    }
}
