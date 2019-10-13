using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace EcommerceSite.Repository
{
    public interface IRepository<Tbl_Entity> where Tbl_Entity : class
    {
        IEnumerable<Tbl_Entity> GetAllRecords();
        IQueryable<Tbl_Entity> GetAllRecordsIQueryable();

        int GetAllRecordCount();

        void add(Tbl_Entity entity);

        void update(Tbl_Entity entity);

        void UpdateByWhereClause(Expression<Func<Tbl_Entity, bool>> wherePredict, Action<Tbl_Entity> ForEachPredict);

        Tbl_Entity GetFirstorDefault(int recordId);
        void Remove(Tbl_Entity entity);

        void RemoveByWhereClause(Expression<Func<Tbl_Entity, bool>> wherePredict);

        void RemoveRangeByWhereClause(Expression<Func<Tbl_Entity, bool>> wherePredict);

        void InactiveAndDeleteMarkByWhereClause(Expression<Func<Tbl_Entity, bool>> wherePredict, Action<Tbl_Entity> ForEachPredict);

        Tbl_Entity GetFirstOrDefaultByParameter(Expression<Func<Tbl_Entity, bool>> wherePredict);

        IEnumerable<Tbl_Entity> GetListParameter(Expression<Func<Tbl_Entity, bool>> wherePredict);

        IEnumerable<Tbl_Entity> GetResultBySqlProcedure(string query, params object[] parameters);

        IEnumerable<Tbl_Entity> GetRecordsToShow(int pageNo, int pageSize, int currentPage, Expression<Func<Tbl_Entity, bool>> wherePredict, Expression<Func<Tbl_Entity, int>> orderByPredict);

    }
}