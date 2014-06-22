namespace Archer.Core.Repository
{
	using System;
	using System.Collections.Generic;
	using System.Linq.Expressions;
	using Archer.Core.Entity;

	public interface IReadRepository<TEntity> where TEntity : IEntity
	{
		IList<TEntity> All();

		TEntity GetById(string id);

		IList<TEntity> Where(Expression<Func<TEntity, bool>> predicate);
	}
}