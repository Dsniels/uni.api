using System;
using System.Linq.Expressions;

namespace uni.learn.core.Interfaces;

public interface ISpecifications<T>
{
    public Expression<Func<T,bool>> Criteria {get;}
    List<Expression<Func<T,object>>> Includes {get;}
    Expression<Func<T,object>> OrderBy {get;}
    
}
