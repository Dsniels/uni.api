using System;
using System.Linq.Expressions;
using uni.learn.core.Interfaces;

namespace uni.learn.core.Specifications;

public class BaseSpecifications<T> : ISpecifications<T>
{
    public BaseSpecifications(){}
    public BaseSpecifications(Expression<Func<T,bool>> criteria){
        Criteria = criteria;
    }
    public Expression<Func<T, bool>> Criteria {get;}

    public List<Expression<Func<T, object>>> Includes {get;} = new List<Expression<Func<T,object>>>();

    public Expression<Func<T, object>> OrderBy {get; private set;} 


    protected void AddIncludes(Expression<Func<T,object>> includeExpression){ Includes.Add(includeExpression);}

    protected void AddOrderBy(Expression<Func<T,object>> orderBy){OrderBy = orderBy;}
    
}
