using Dapper;
using System;
using System.Collections.Generic;
using System.Text;


namespace SarbjitSBooks.DataAccess.Repository.IRepository
{
    public interface ISP_Call : IDisposable
    {
        T Single<T>(string procedurename, DynamicParameters param=null);
        void Execute(string procedurename, DynamicParameters param = null);

        // retrieves the complete row or record

        T OneRecord<T>(string procedurename, DynamicParameters param = null);

        // get all of the rous


        IEnumerable<T> List<T>(string procedurename, DynamicParameters param = null);

        // stored proceedure that returns two tables

        Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1, T2>(string procedurename, DynamicParameters param = null);
    }
}
