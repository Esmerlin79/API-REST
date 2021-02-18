using RepositoryModel.response;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Repository.Interface
{
    public interface IRepository<DB>
    {
        IEnumerable<Ent> Find<Ent>(Expression<Func<Ent, bool>> specification) where Ent : class;
        IEnumerable<Ent> GetAll<Ent>() where Ent : class;
        Ent GetById<Ent>(int id) where Ent : class;
        DataResult Insert<Ent>(Ent entity) where Ent : class ;
        DataResult Edit<Ent>(Ent entity) where Ent : class ;
        DataResult Delete<Ent>(int id) where Ent : class;
    }
}
