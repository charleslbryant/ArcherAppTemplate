namespace Archer.Core.Repository
{
	using System;
	using Archer.Core.Entity;

	public interface IWriteRepository<TEntity> where TEntity : IEntity
	{
		bool Delete(TEntity entity);

		bool Insert(TEntity entity);

		bool Update(TEntity entity);
	}
}