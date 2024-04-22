﻿using ElectraNet.Domain.Commons;
using ElectraNet.Domain.Enitites.Cables;
using System.Linq.Expressions;

namespace ElectraNet.DataAccess.Repositories;

public interface IRepository<T> where T : Auditable
{
    ValueTask<T> InsertAsync(T entity);
    ValueTask<T> UpdateAsync(T entity);
    ValueTask<T> DeleteAsync(T entity);
    ValueTask<T> DropAsync(T entity);
    ValueTask<T> SelectAsync(Expression<Func<T, bool>> expression, string[] includes = null);
    ValueTask<IEnumerable<T>> SelectAsEnumerableAsync(Expression<Func<T, bool>> expression = null,string[] includes = null, bool isTracked = true);
    IQueryable<T> SelectAsQueryable(Expression<Func<T, bool>> expression = null,string[] includes = null, bool isTracked = true);
    Task UpdateAsync(Cable existCable);
}