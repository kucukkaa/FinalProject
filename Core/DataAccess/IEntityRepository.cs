using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{

    //generic constraint = kısıt
    
    
    public interface IEntityRepository<T> where T:class,IEntity,new()   //referans tip olabilir demek yalnızca class anlamına gelmez, IEntity olabilir ya da implemente eden bir nesne olabilir. ayrıca yalnızca newlenebilir nesne eklenebilir. bu sayede IEntity de elenmiş olur.
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
